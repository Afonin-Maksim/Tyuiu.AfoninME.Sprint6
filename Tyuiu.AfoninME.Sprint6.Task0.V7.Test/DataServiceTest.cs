using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AfoninME.Sprint6.Task0.V7.Lib;

namespace Tyuiu.AfoninME.Sprint6.Task0.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            int x = 3;
            double actual = ds.Calculate(x);
            double expected = 0.211;
            Assert.AreEqual(expected, actual);
        }
    }
}