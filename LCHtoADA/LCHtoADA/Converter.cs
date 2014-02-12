using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace LCHtoADA
{
    public class Converter
    {
        private static readonly Dictionary<string, string> ForecastRateDict = new Dictionary<string, string>()
        {
            { "AUD", "AUD_BBSW" },
            { "CAD", "CAD_CDOR" },
            { "CHF", "CHF_LIBOR" },
            { "CZK", "CZK_PRIBOR" },
            { "DKK", "DKK_NIBOR" },
            { "EUR", "EUR_EURIBOR" },
            { "GBP", "GBP_LIBOR" },
            { "HKD", "HKD_HIBOR" },
            { "HUF", "HUF_BUBOR" },
            { "JPY", "JPY_LIBOR" },
            { "NOK", "NOK_NIBOR" },
            { "NZD", "NZD_BKBM" },
            { "PLN", "PLN_WIBOR" },
            { "SEK", "SEK_STIBOR" },
            { "SGD", "SGD_SOR" },
            { "USD", "USD_LIBOR" },
            { "ZAR", "ZAR_JIBAR" }
        };

        private static readonly Dictionary<string, string> CurveCurrenciesDict = new Dictionary<string, string>()
        {
            { "AUD_BBSW", "AUD" },
            { "CAD_CDOR", "CAD" },
            { "CAD_CORRA", "CAD" },
            { "CHF_LIBOR", "CHF" },
            { "CHF_TOIS", "CHF" },
            { "CZK_PRIBOR", "CZK" },
            { "DKK_CIBOR", "DKK" },
            { "EUR_EONIA", "EUR" },
            { "EUR_EURIBOR", "EUR" },
            { "GBP_LIBOR", "GBP" },
            { "GBP_SONIA", "GBP" },
            { "HKD_HIBOR", "HKD" },
            { "HUF_BUBOR", "HUF" },
            { "JPY_LIBOR", "JPY" },
            { "NOK_NIBOR", "NOK" },
            { "NZD_BKBM", "NZD"} ,
            { "PLN_WIBOR", "PLN" },
            { "SEK_STIBOR", "SEK" },
            { "SGD_SOR", "SGD" },
            { "USD_FEDFUND", "USD" },
            { "USD_LIBOR", "USD" },
            { "ZAR_JIBAR", "ZAR" }
        };

        private Report18 fReport18;
        private Report79 fReport79;
        private Report90 fReport90;
        private DataTable fADATable = new DataTable();

        public Converter(Report18 r18, Report79 r79, Report90 r90)
        {
            try
            {
                if (!this.HaveSameBaseDate(new LCHFile[] { r18, r79, r90 }))
                    throw new ArgumentException();

                fReport18 = r18;
                fReport79 = r79;
                fReport90 = r90;
                this.BuildADATable();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Files don't have same base dates.");
            }
        }

        public DateTime BaseDate { get { return fReport18.BaseDate; } }

        public void BuildADATable()
        {
            var dc = new DataColumn("DATE", typeof(double));
            fADATable.Columns.Add(dc);

            foreach (string curveName in CurveCurrenciesDict.Keys)
            {
                List<double> tenors = fReport79.AvailableTenors(curveName);
                foreach (double tenor in tenors)
                {
                    string colName = string.Format("InterestRate.{0},{1}", curveName, tenor);
                    dc = new DataColumn(colName, typeof(double));
                    fADATable.Columns.Add(dc);
                }
            }

            foreach (string ccy in ForecastRateDict.Keys)
            {
                string colName = string.Format("FxRate.{0}", ccy);
                dc = new DataColumn(colName, typeof(double));
                fADATable.Columns.Add(dc);
            }
        }

        public void FillADATable()
        {
            List<DateTime> dates = fReport90.AllDates();
            
            // TODO Check that 5 business days before base date doesn't overlap with the dates just found.
            // First fill in first 5 rows: the dates will be the last 5 days from the base date
            const int VarHorizon = 5;
            for (int i = 0; i < VarHorizon; i++)
            {
                DateTime date = BaseDate.AddWorkingDays(-i);
                DataRow row = fADATable.NewRow();

                // Fill in date
                row["Date"] = date.ToOADate();
                
                // Fill in zero rates from report 79
                foreach (string curveName in CurveCurrenciesDict.Keys)
                {
                    List<double> tenors = fReport79.AvailableTenors(curveName);
                    foreach (double tenor in tenors)
                    {
                        string colName = string.Format("InterestRate.{0},{1}", curveName, tenor);
                        row[colName] = fReport79[curveName, tenor];
                    }
                }

                foreach (string ccy in ForecastRateDict.Keys)
                {
                    string colName = string.Format("FxRate.{0}", ccy);
                    row[colName] = 1.0 / fReport18[ccy];
                }

                fADATable.Rows.Add(row);
            }

            // Now work back through dates and add rows using the scenario shifts.
            int rowNum = VarHorizon;
            foreach (DateTime date in dates)
            {
                DataRow row = fADATable.NewRow();

                row["Date"] = date.ToOADate();

                foreach (string curveName in CurveCurrenciesDict.Keys)
                {
                    List<double> tenors = fReport79.AvailableTenors(curveName);
                    foreach (double tenor in tenors)
                    {
                        string colName = string.Format("InterestRate.{0},{1}", curveName, tenor);
                        double shift = fReport90[curveName, date, YearFracToTermString(tenor)];
                        shift *= 0.0001; // convert from bp to actual value.
                        row[colName] = UndoRateShift((double)fADATable.Rows[rowNum - VarHorizon][colName], shift);
                    }
                }

                foreach (string ccy in ForecastRateDict.Keys)
                {
                    string colName = string.Format("FxRate.{0}", ccy);
                    double shift = fReport90[ccy, date];
                    shift *= 0.01; // convert from % to actual value.
                    row[colName] = this.UndoFxShift((double)fADATable.Rows[rowNum - VarHorizon][colName], shift);
                }

                rowNum++;
                fADATable.Rows.Add(row);
                Console.WriteLine(rowNum);
            }
        }

        public void ToADA(string outPath)
        {
            using (StreamWriter sw = new StreamWriter(outPath))
                sw.Write(this.ToADA());
        }

        public string ToADA()
        {
            StringBuilder text = new StringBuilder(string.Empty);
            text.Append("# LCH returns data\n");
            text.Append("#Columns\tRows\n");
            text.AppendFormat("{0}\t{1}\n", fADATable.Columns.Count, fADATable.Rows.Count);

            foreach (DataColumn column in fADATable.Columns)
                text.AppendFormat("{0}\t", column.ColumnName);

            text = text.Remove(text.Length - 1, 1);
            text.Append("\nSeedVol\nVolFloor\n");

            for (int i = fADATable.Rows.Count - 1; i >= 0; i--)
            {
                foreach (DataColumn dc in fADATable.Columns)
                {
                    text.AppendFormat("{0}\t", fADATable.Rows[i][dc]);
                }

                text = text.Remove(text.Length - 1, 1);
                text.AppendFormat("\n");
            }

            return text.ToString();
        }

        public void ToDat(string outPath)
        {
            using (StreamWriter sw = new StreamWriter(outPath))
                sw.Write(this.ToDat());
        }

        public string ToDat()
        {
            StringBuilder text = new StringBuilder(string.Empty);

            text.Append("AnalyticsVersion=141.0\n");
            text.Append("\n");
            text.Append("<System Parameters>\n");
            text.Append("Base_Currency=GBP\n");
            text.Append("Description=\n");
            text.Append(string.Format("Base_Date={0:ddMMMyyyy}\n", BaseDate));
            text.Append("Exclude_Deals_With_Missing_Market_Data=Yes\n");
            text.Append("Proxying_Rules_File=\n");
            text.Append("Script_Base_Scenario_Multiplier=1\n");
            text.Append("Correlations_Healing_Method=Eigenvalue_Raising\n");
            text.Append("Grouping_File=Grouping.txt\n");
            text.Append("\n");
            text.Append("<Model Configuration>\n");
            text.Append("\n");

            // THIS IS WHERE THE GOOD STUFF HAPPENS
            text.Append("<Price Factors>\n");
            foreach (string ccy in ForecastRateDict.Keys)
            {
                text.Append(FxPriceFactorLine(ccy));
            }

            foreach (string ccy in ForecastRateDict.Keys)
            {
                text.Append(DummyRatePriceFactorLine(ccy));
            }

            foreach (string curveName in CurveCurrenciesDict.Keys)
            {
                text.Append(ActualRatePriceFactorLine(curveName));
            }

            text.Append("\n");

            text.Append("<Price Models>\n");
            text.Append("\n");
            text.Append("<Correlations>\n");
            text.Append("\n");
            text.Append("<Valuation Configuration>\n");
            text.Append("\n");
            text.Append("<Market Prices>\n");
            text.Append("\n");
            text.Append("<Bootstrapper Configuration>\n");
            text.Append("\n");

            return text.ToString();
        }

        public bool HaveSameBaseDate(IList<LCHFile> files)
        {
            bool result = true;
            foreach (LCHFile file in files)
            {
                if (file.BaseDate != files[0].BaseDate)
                    result = false;
            }

            return result;
        }

        private string FxPriceFactorLine(string ccy)
        {
            return string.Format("FxRate.{0},Property_Aliases=,Spot={1},Domestic_Currency=,Interest_Rate={2},Priority=0\n", ccy, 1.0 / fReport18[ccy], ForecastRateDict[ccy]);
        }

        private string DummyRatePriceFactorLine(string ccy)
        {
            return string.Format("InterestRate.{0},Property_Aliases=,Curve=[(0,0)],Currency=,Day_Count=ACT_365,Accrual_Calendar=,Sub_Type=,Floor=<undefined>\n", ccy);
        }

        private string ActualRatePriceFactorLine(string curveName)
        {
            StringBuilder line = new StringBuilder(string.Empty);
            line.AppendFormat("InterestRate.{0},Property_Aliases=,Curve=[", curveName);

            string filter = string.Format("Curve = '{0}'", curveName + "_EOD");
            DataRow[] rows = fReport79.DataTable.Select(filter);

            foreach (DataRow dataRow in rows)
            {
                line.AppendFormat("({0},{1}),", dataRow["AccrualFactor"], dataRow["ZeroRate"]);
            }

            // remove trailing comma
            line = line.Remove(line.Length - 1, 1);

            line.Append("],");
            line.Append(string.Format("Currency={0},Day_Count=ACT_365,Accrual_Calendar=,Sub_Type=,Floor=<undefined>", CurveCurrenciesDict[curveName]));
            line.Append("\n");
            return line.ToString();
        }
        
        private double UndoRateShift(double x, double shift)
        {
            return x - shift;
        }

        private double UndoFxShift(double x, double shift)
        {
            return (1.0 + shift) * x;
        }

        private bool IsClose(double x, double y, double tol)
        {
            return Math.Abs(x / y - 1) < tol;
        }

        private string YearFracToTermString(double yearFrac)
        {
            // TODO Do this properly
            double tol = 1e-2;
            if (IsClose(yearFrac, 0.002739726027397, tol))
                return "ON";
            if (IsClose(yearFrac, 0.019178082191781, tol))
                return "1W";
            if (IsClose(yearFrac, 0.038356164383562, tol))
                return "2W";
            if (IsClose(yearFrac, 0.057534246575343, tol))
                return "3W";
            if (IsClose(yearFrac, 0.082191780821918, tol))
                return "1M";
            if (IsClose(yearFrac, 0.164383561643836, tol))
                return "2M";
            if (IsClose(yearFrac, 0.249315068493151, tol))
                return "3M";
            if (IsClose(yearFrac, 0.331506849315069, tol))
                return "4M";
            if (IsClose(yearFrac, 0.416438356164384, tol))
                return "5M";
            if (IsClose(yearFrac, 0.498630136986301, tol))
                return "6M";
            if (IsClose(yearFrac, 0.580821917808219, tol))
                return "7M";
            if (IsClose(yearFrac, 0.665753424657534, tol))
                return "8M";
            if (IsClose(yearFrac, 0.747945205479452, tol))
                return "9M";
            if (IsClose(yearFrac, 0.832876712328767, tol))
                return "10M";
            if (IsClose(yearFrac, 0.915068493150685, tol))
                return "11M";
            if (IsClose(yearFrac, 1.000000000000000, tol))
                return "1Y";
            if (IsClose(yearFrac, 1.249315068493150, tol))
                return "15M";
            if (IsClose(yearFrac, 1.498630136986300, tol))
                return "18M";
            if (IsClose(yearFrac, 1.747945205479450, tol))
                return "21M";
            if (IsClose(yearFrac, 2, tol))
                return "2Y";
            if (IsClose(yearFrac, 3, tol))
                return "3Y";
            if (IsClose(yearFrac, 4, tol))
                return "4Y";
            if (IsClose(yearFrac, 5, tol))
                return "5Y";
            if (IsClose(yearFrac, 6, tol))
                return "6Y";
            if (IsClose(yearFrac, 7, tol))
                return "7Y";
            if (IsClose(yearFrac, 8, tol))
                return "8Y";
            if (IsClose(yearFrac, 9, tol))
                return "9Y";
            if (IsClose(yearFrac, 10, tol))
                return "10Y";
            if (IsClose(yearFrac, 12, tol))
                return "12Y";
            if (IsClose(yearFrac, 15, tol))
                return "15Y";
            if (IsClose(yearFrac, 20, tol))
                return "20Y";
            if (IsClose(yearFrac, 25, tol))
                return "25Y";
            if (IsClose(yearFrac, 30, tol))
                return "30Y";
            if (IsClose(yearFrac, 35, tol))
                return "35Y";
            if (IsClose(yearFrac, 40, tol))
                return "40Y";
            if (IsClose(yearFrac, 45, tol))
                return "45Y";
            if (IsClose(yearFrac, 50, tol))
                return "50Y";
            
            return string.Empty;
        }
    }
}
