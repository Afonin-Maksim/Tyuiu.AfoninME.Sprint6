using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AfoninME.Sprint6.Task4.V17.Lib;

namespace Tyuiu.AfoninME.Sprint6.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestFunction()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);

            Assert.AreEqual(-10.36, res[0]);
            Assert.AreEqual(-1.32, res[5]);
            Assert.AreEqual(17.28, res[10]);
        }
    }
}