using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AfoninME.Sprint6.Task3.V5.Lib;

namespace Tyuiu.AfoninME.Sprint6.Task3.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculateColumnSort()
        {
            int[,] input =
            {
                { 30, -20,  7,  -8,  9 },
                { 32,  17, -14,  -7, 33 },
                { 19, -19, -13,  14, -20 },
                { 11,  30,  -1,  26,   6 },
                { 30, -15, -20,  -5,  15 }
            };

            int[,] expected =
            {
                { 30, -20, -20,  -8,  9 },
                { 32,  17, -14,  -7, 33 },
                { 19, -19, -13,  14, -20 },
                { 11,  30,  -1,  26,   6 },
                { 30, -15,   7,  -5, 15 }
            };

            DataService ds = new DataService();
            int[,] res = ds.Calculate(input);

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    Assert.AreEqual(expected[i, j], res[i, j]);
        }
    }
}