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
        public void SetUp()
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

        [TestMethod]
        public void SingleFilter()
        {
            DataFrame df = ReturnDataFrame();
            df.TryAddLine(new string[] { "18/11/2013", "GBP", "24", "0.0035" });
            df.TryAddLine(new string[] { "18/11/2013", "AUD", "4", "0.088" });

            Dictionary<string, string> filters = new Dictionary<string, string>() { { "ccy", "AUD" } };
            dynamic x = df.FirstOrFalse(filters, "1w");

            Assert.AreEqual(x, 0.088, 1e-6);
        }

        [TestMethod]
        public void MultipleFilters()
        {
            DataFrame df = ReturnDataFrame();
            df.TryAddLine(new string[] { "18/11/2013", "GBP", "24", "0.0035" });
            df.TryAddLine(new string[] { "18/11/2013", "AUD", "4", "0.088" });
            df.TryAddLine(new string[] { "18/11/2013", "AUD", "2", "0.971" });

            var filters = new Dictionary<string, string>() { { "ccy", "AUD" }, { "scenario", "2" } };
            dynamic x = df.FirstOrFalse(filters, "1w");

            Assert.AreEqual(x, 0.971, 1e-6);
        }

        [TestMethod]
        public void UnmatchedFilters()
        {
            DataFrame df = ReturnDataFrame();
            df.TryAddLine(new string[] { "18/11/2013", "GBP", "24", "0.0035" });
            df.TryAddLine(new string[] { "18/11/2013", "AUD", "4", "0.088" });
            df.TryAddLine(new string[] { "18/11/2013", "AUD", "2", "0.971" });

            var filters = new Dictionary<string, string>() { { "ccy", "GBP" }, { "scenario", "2" } };
            dynamic x = df.FirstOrFalse(filters, "1w");

            Assert.IsFalse(x);
        }
    }
}
