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
            var dc = new DataColumn("Date", typeof(int));
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
            return files.All(file => file.BaseDate == files[0].BaseDate);
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
    }
}
