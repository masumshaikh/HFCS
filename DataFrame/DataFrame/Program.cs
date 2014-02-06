using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Reflection;

namespace DataFrameNameSpace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var headers = new string[] { "date", "ccy", "scenario", "1w" };
            var types = new string[] { "date", "string", "int", "double" };

            var df = new DataFrame(headers, types);

            df.TryAddLine(new string[] { "18/11/2013", "GBP", "24", "0.0035" });
            df.TryAddLine(new string[] { "18/11/2013", "AUD", "4", "0.088" });
            df.TryAddLine(new string[] { "18/11/2013", "AUD", "2", "0.971" });


            var filters = new Dictionary<string, string>() { { "ccy", "AUD" }, { "scenario", "2" } };
            dynamic x = df.FirstOrFalse(filters,"1w");
        }
    }
}
