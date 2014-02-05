using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DataFrameTest
{
    [TestClass]
    public class DataFrameTest
    {
        public static DataFrame.DataFrame ReturnDataFrame()
        {
            var dataFrame = new DataFrame.DataFrame(
                new List<string>() { "ford", "vauxhall" },
                new List<string>() { "35932", "35933" },
                new dynamic[,] { { 1.1, 1.2 }, { 2.1, 2.2 } });
            return dataFrame;
        }

        [TestMethod]
        public void DataFrame_SetUp()
        {
            var dataFrame = ReturnDataFrame();
            Assert.AreEqual(2.1, dataFrame["ford", "35933"], 1e-6);
        }

        [TestMethod]
        public void DataFrame_Set()
        {
            var dataFrame = ReturnDataFrame();
            dataFrame["ford", "35933"] = 5.4;
            Assert.AreEqual(5.4, dataFrame["ford", "35933"], 1e-6);
        }

        [TestMethod]
        public void DataFrame_MixedValueTypesSetUp()
        {
            var df = new DataFrame.DataFrame(new List<string>() { "Currency", "Index", "Number", "1W" }, 1);
            df["Currency", 0] = "GBP";
            df["Index", 0] = "LIBOR";
            df["1W", 0] = 0.062;
            Assert.AreEqual(0.062, df["1W", 0], 1e-6);
        }
    }
}
