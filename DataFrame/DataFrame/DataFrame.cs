using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

using System.Linq;
using System.Text;

namespace DataFrameNameSpace
{
    public class DataFrame
    {
        private string[] fColumnHeaders;
        private string[] fColumnTypeStrings;
        private DataColumn[] fColumns;

        public DataFrame(string[] columnHeaders, string[] columnTypes)
        {
            fColumnHeaders = columnHeaders;
            fColumnTypeStrings = columnTypes;
            
            fColumns = new DataColumn[fColumnTypeStrings.Length];

            Debug.Assert(fColumnHeaders.Length == fColumnTypeStrings.Length, "The list of column headers did not have the same number of elements as the specifications of the data types in each columnn");

            for (int i = 0; i < fColumnHeaders.Length; i++)
            {
                fColumns[i] = new DataColumn(fColumnHeaders[i], fColumnTypeStrings[i]);
            }
        }
        
        public bool TryAddLine(string[] args)
        {
            if (args.Length != fColumnHeaders.Length)
                return false;

            bool success = true;
            for (int i = 0; i < fColumnHeaders.Length; i++)
            {
                // The false flag previews the addition of the new line without actually adding to the columns
                success = success && fColumns[i].TryAdd(args[i], false);
            }

            // If any of the columns failed, don't do anything and return false
            if (!success)
                return false;

            // Now that we know all the columns were successful in the preview, go ahead and add the new line for real (ie, with the true flag)
            for (int i = 0; i < fColumnHeaders.Length; i++)
            {
                fColumns[i].TryAdd(args[i], true);
            }

            return true;
        }

        public void TestFilter(string singleFilter)
        {
            Type temp = fColumns[1].DataType;
            var filtered = fColumns[1].Data.Cast<object>().Where(s => (string)s == singleFilter);
        }
    }
}
