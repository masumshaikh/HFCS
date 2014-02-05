using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DataFrameTest
{
    [TestClass]
    public class DataFrameTest
    {
        [TestMethod]
        public void DataFrame_SetUp()
        {
            var dataFrame = new DataFrame.DataFrame(
                new List<string>() { "ford", "vauxhall" },
                new List<string>() { "35932", "35933" },
                new dynamic[,] { { 1.1, 1.2 }, { 2.1, 2.2 } });

            Assert.AreEqual(2.1, dataFrame["ford", "35933"], 1e-6);
        }
    }
}
