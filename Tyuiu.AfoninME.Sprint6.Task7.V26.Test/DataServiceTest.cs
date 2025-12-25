using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AfoninME.Sprint6.Task7.V26.Lib;

namespace Tyuiu.AfoninME.Sprint6.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ProcessMatrix_ShouldReplacePositiveMoreThan5_InSecondColumnOnly()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();
            File.WriteAllLines(path, new[]
            {
                "2 10 3",
                "-5 7 8",
                "1 -3 4"
            });

            int[,] matrix = ds.LoadMatrix(path);
            int[,] result = ds.ProcessMatrix(matrix);

            // Проверяем замену
            Assert.AreEqual(222, result[0, 1]);
            Assert.AreEqual(222, result[1, 1]);    // 7 -> 222
            Assert.AreEqual(-3, result[2, 1]);     // отрицательные не меняем

            // Проверяем, что исходная матрица осталась неизменной
            Assert.AreEqual(10, matrix[0, 1]);
        }
    }
}