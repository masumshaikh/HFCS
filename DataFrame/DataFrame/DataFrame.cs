using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataFrame
{
    public class DataFrame
    {
        private List<string> fColumnHeaders;
        private List<string> fRowHeaders;
        private dynamic[,] fValues;

        public DataFrame(List<string> columnHeaders, List<string> rowHeaders)
        {
            // todo check that column and row headers being passed contain no duplicates
            fColumnHeaders = columnHeaders;
            fRowHeaders = rowHeaders;
            fValues = new dynamic[fRowHeaders.Count, fColumnHeaders.Count];
        }

        public DataFrame(List<string> columnHeaders, List<string> rowHeaders, dynamic[,] values)
        {
            // todo check that column and row headers being passed contain no duplicates
            fColumnHeaders = columnHeaders;
            fRowHeaders = rowHeaders;

            // todo dimensions are for losers
            fValues = values;
        }

        public dynamic this[string colName, string rowName]
        {
            get
            {
                // todo do something if r and c not found below
                int r = fRowHeaders.IndexOf(rowName);
                int c = fColumnHeaders.IndexOf(colName);

                return fValues[r, c];
            }

            set
            {
                // todo do something if r and c not found below
                int r = fRowHeaders.IndexOf(rowName);
                int c = fColumnHeaders.IndexOf(colName);

                fValues[r, c] = value;
            }
        }
    }
}
