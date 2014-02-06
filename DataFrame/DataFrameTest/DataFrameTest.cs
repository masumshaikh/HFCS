using DataFrameNameSpace;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DataFrameTest
{
    [TestClass]
    public class DataFrameTest
    {
        public static DataFrame ReturnDataFrame()
        {
            string[] headers = new string[] { "date", "ccy", "scenario", "1w" };
            string[] types = new string[] { "date", "string", "int", "double" };

            DataFrame df = new DataFrame(headers, types);

            return df;
        }

        [TestMethod]
        public void DataFrame_SetUp()
        {
            DataFrame df = ReturnDataFrame();
            bool success = df.TryAddLine(new string[] { "18/11/2013", "GBP", "24", "0.0035" });
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void TryToMakeJaggedColumns()
        {
            DataFrame df = ReturnDataFrame();
            bool success = df.TryAddLine(new string[] { "18/11/2013", "GBP", "asdf", "0.0035" });
            Assert.IsFalse(success);
        }
    }
}
