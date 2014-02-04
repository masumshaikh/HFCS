using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataFrame
{
    class DataFrame
    {
        private List<string> fColumnHeaders;
        private List<string> fRowHeaders;
        private double[,] fValues;

        public DataFrame(List<string> columnHeaders, List<string> rowHeaders)
        {
            fColumnHeaders = columnHeaders;
            fRowHeaders = rowHeaders;
            fValues = new double[fRowHeaders.Count, fColumnHeaders.Count];
        }

        public DataFrame(List<string> columnHeaders, List<string> rowHeaders, double[,] values)
        {
            fColumnHeaders = columnHeaders;
            fRowHeaders = rowHeaders;
            fValues = values;

            // todo dimensions are for losers
        }

        public double this[string colName, string rowName]
        {
            get
            {
                // find index of rowName in fRowHeaders
                int r = fRowHeaders.IndexOf(rowName);
                int c = fColumnHeaders.IndexOf(rowName);

                return fValues[r, c];
            }
        }

    }
}
