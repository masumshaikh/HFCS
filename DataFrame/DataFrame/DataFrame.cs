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
            // todo check that column being passed contain no duplicates
            // todo row headers may contain duplicates
            fColumnHeaders = columnHeaders;
            fRowHeaders = rowHeaders;
            fValues = new dynamic[fRowHeaders.Count, fColumnHeaders.Count];
        }

        public DataFrame(List<string> columnHeaders, List<string> rowHeaders, dynamic[,] values)
        {
            // todo check that column being passed contain no duplicates
            // todo row headers may contain duplicates
            fColumnHeaders = columnHeaders;
            fRowHeaders = rowHeaders;

            // todo dimensions are for losers
            fValues = values;
        }

        public DataFrame(List<string> columnHeaders, int numRows)
        {
            fColumnHeaders = columnHeaders;
            fValues = new dynamic[numRows, fColumnHeaders.Count];
        }

        ////public dynamic this[string colName, string rowName]
        ////{
        ////    get
        ////    {
        ////        // todo do something if r and c not found below
        ////        int r = fRowHeaders.IndexOf(rowName);
        ////        int c = fColumnHeaders.IndexOf(colName);

        ////        return fValues[r, c];
        ////    }

        ////    set
        ////    {
        ////        // todo do something if r and c not found below
        ////        int r = fRowHeaders.IndexOf(rowName);
        ////        int c = fColumnHeaders.IndexOf(colName);

        ////        fValues[r, c] = value;
        ////    }
        ////}

        public dynamic this[string colName, int rowNum]
        {
            get
            {
                int c = fColumnHeaders.IndexOf(colName);
                return fValues[rowNum, c];
            }
            set
            {
                int c = fColumnHeaders.IndexOf(colName);
                fValues[rowNum, c] = value;
            }
        }

        public dynamic this[string colName, string conditionString]
        {
            // Conditions is sth like "Currency=GBP,Index=LIBOR". Find index of a row which matches conditionString. Return colName for that row.
            // Split conditionString on commas
            get
            {
                string[] conditions = conditionString.Split(',');
                Dictionary<string, string> conditionsDict = new Dictionary<string,string>();
                
                // Build dictionary { (Currency, GBP), (Index, Libor) }
                foreach (string condition in conditions)
                {
                    string[] temp = condition.Split('=');
                    conditionsDict[temp[0]] = temp[1];
                }

                // make sure that colName isn't equal to any of the conditions

                // loop through fValues and find a row such that all the conditions match
            }
        }
    }
}
