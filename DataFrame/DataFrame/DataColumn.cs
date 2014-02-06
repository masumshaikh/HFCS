using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataFrameNameSpace
{
    public class DataColumn
    {
        private static readonly Dictionary<string, string> TypeDict = new Dictionary<string, string>() { { "int", "System.Int32" }, { "double", "System.Double" }, { "string", "System.String" }, { "date", "System.DateTime"} };
        private string fDataTypeMnemonic;
        private string fColumnName;

        public DataColumn(string columnName, string dataTypeMnemonic)
        {
            fColumnName = columnName;
            fDataTypeMnemonic = dataTypeMnemonic;

            string dataTypeFull = TypeDict[dataTypeMnemonic];
            DataType = Type.GetType(dataTypeFull);
            Type listType = typeof(List<>);
            Type combinedType = listType.MakeGenericType(DataType);
            Data = (IList)Activator.CreateInstance(combinedType);
        }

        public IList Data { get; set; }
        public Type DataType { get; private set; }

        public bool TryAdd(string dataToAdd, bool forReal)
        {
            bool success = false;

            switch (fDataTypeMnemonic)
            {
                case "int":
                    int tempInt;
                    success = int.TryParse(dataToAdd, out tempInt);
                    if (forReal) Data.Add(tempInt);
                    break;

                case "double":
                    double tempDouble;
                    success = double.TryParse(dataToAdd, out tempDouble);
                    if (forReal) Data.Add(tempDouble);
                    break;

                case "string":
                    if (forReal) Data.Add(dataToAdd);
                    success = true;
                    break;

                case "date":
                    DateTime tempDate;
                    success = DateTime.TryParse(dataToAdd, out tempDate);
                    if (forReal) Data.Add(tempDate);
                    break;
            }

            return success;
        }

        public override string ToString()
        {
            return fColumnName;
        }
    }
}
