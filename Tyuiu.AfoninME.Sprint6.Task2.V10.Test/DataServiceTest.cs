using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AfoninME.Sprint6.Task2.V10.Lib;

namespace Tyuiu.AfoninME.Sprint6.Task2.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestGetMassFunction()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);

            // Проверим характерные значения
            Assert.AreEqual(-14.64, res[0]); // x = -5
            Assert.AreEqual(-4.0, res[5]);   // x = 0
            Assert.AreEqual(10.82, res[10]); // x = 5
        }
    }
}