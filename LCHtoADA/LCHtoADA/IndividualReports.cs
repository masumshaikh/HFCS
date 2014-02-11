using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LCHtoADA
{
    public class Report79 : LCHFile
    {
        private static readonly string[] DataTypes = new string[] { "System.String", "System.DateTime", "System.DateTime", "System.Double", "System.Double", "System.Double" };
        
        public Report79(string path)
            : base(path, DataTypes, '\t')
        {
        }

        public override DateTime BaseDate
        {
            get
            {
                return (DateTime)fDataTable.Rows[0]["CloseDate"];
            }
        }

        public List<double> AvailableTenors(string curveName)
        {
            var listOut = new List<double>();
            string filter = string.Format("Curve = '{0}_EOD'", curveName);
            DataRow[] rows = fDataTable.Select(filter);

            foreach (DataRow row in rows)
            {
                listOut.Add((double)row["AccrualFactor"]);
            }

            return listOut;
        }
    }

    public class Report18 : LCHFile
    {
        private static readonly string[] DataTypes = new string[] { "System.DateTime", "System.String", "System.String", "System.String", "System.String", "System.Double" };

        public Report18(string path)
            : base(path, DataTypes, '\t')
        {
        }

        public override DateTime BaseDate
        {
            get
            {
                return (DateTime)fDataTable.Rows[0]["CobDate"];
            }
        }

        public double this[string fromCurrency]
        {
            get
            {
                string filter = string.Format("FromCurrency = '{0}' And ToCurrency = 'GBP'", fromCurrency);
                
                DataRow[] foundRows = fDataTable.Select(filter);
                if (foundRows.Length > 0)
                    return (double)foundRows[0]["ExchangeRate"];
                else
                    return -1.0;
            }
        }
    }

    public class Report90 : LCHFile
    {
        private static readonly string[] DataTypes = new string[] { "System.DateTime", "System.String", "System.String", "System.DateTime", "System.Int32", "System.Int32", "System.Int32", "System.String", "System.Double", "System.Double", "System.String", "System.String", "System.String", "System.String", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double", "System.Double" };

        public Report90(string path)
            : base(path, DataTypes, '\t')
        {
        }

        public override DateTime BaseDate
        {
            get
            {
                return (DateTime)fDataTable.Rows[0]["CloseDate"];
            }
        }
    }
}
