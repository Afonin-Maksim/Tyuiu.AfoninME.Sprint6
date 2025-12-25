using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AfoninME.Sprint6.Task1.V28.Lib;

namespace Tyuiu.AfoninME.Sprint6.Task1.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestGetMassFunction()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);

            // Проверим несколько характерных значений
            Assert.AreEqual(20.55, result[0]); // x = -5
            Assert.AreEqual(1.5, result[5]);   // x = 0
            Assert.AreEqual(-15.37, result[10]); // x = 5
        }
    }
}