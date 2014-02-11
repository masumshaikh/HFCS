using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LCHtoADA
{
    using System.IO;

    /// <summary>
    /// Read in any of the LCH report files to a DataTable.
    /// </summary>
    public class LCHFile
    {
        protected DataTable fDataTable = new DataTable();
        protected char[] fDelimiter = new char[1];

        public LCHFile(string path, string[] columnTypes, char delimiter)
        {
            FilePath = path;
            SetUpColumns(columnTypes);
            fDelimiter[0] = delimiter;
            this.ReadInData();
        }



        public DataTable DataTable
        {
            get
            {
                return fDataTable;
            }
        }
        
        private string FilePath { get; set; }

        public void SetUpColumns(string[] columnTypes)
        {
            var streamReader = new StreamReader(FilePath);

            string headers = streamReader.ReadLine();

            string[] columnNames = headers.Split('\t');

            for (int i = 0; i < columnNames.Length; i++)
            {
                string columnName = columnNames[i];
                var dc = new DataColumn(columnName, Type.GetType(columnTypes[i]));
                fDataTable.Columns.Add(dc);
            }

            streamReader.Close();
        }

        public void ReadInData()
        {
            var streamReader = new StreamReader(FilePath);

            streamReader.ReadLine();
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                string[] values = line.Split('\t');
                DataRow dataRow = fDataTable.NewRow();
                
                for (int i = 0; i < fDataTable.Columns.Count; i++)
                {
                    dataRow[i] = values[i];
                }

                fDataTable.Rows.Add(dataRow);
            }

            streamReader.Close();
        }
    }
}
