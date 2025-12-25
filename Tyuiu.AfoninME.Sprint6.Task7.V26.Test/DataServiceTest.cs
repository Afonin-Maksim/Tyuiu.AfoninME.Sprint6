using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AfoninME.Sprint6.Task7.V26.Lib;

namespace Tyuiu.AfoninME.Sprint6.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMatrix_ReplacePositiveGreaterThan5_InSecondColumnOnly()
        {
            // Arrange
            DataService ds = new DataService();

            // создаём временный CSV-файл в системной папке Temp
            string dir = Path.GetTempPath();
            string path = Path.Combine(dir, "InPutFileTask7V26.csv");

            // входные данные: в разных строках есть положительные и отрицательные числа
            File.WriteAllLines(path, new string[]
            {
                "19,9,16,16,-1,11,14,-8,6,-2",
                "-13,-1,10,18,2,-16,-17,12,-17,20",
                "-17,7,11,-14,-14,-10,8,-12,-17,2",
                "-18,-1,-19,19,-1,20,14,9,17,11",
                "2,17,-14,2,8,-4,11,-20,-18,-20",
                "-13,-13,-13,18,-7,-15,13,2,14,3",
                "4,9,-12,-1,-7,7,10,3,19,-11",
                "1,-12,-9,-17,16,-6,1,-8,-17,20",
                "10,1,2,1,3,-19,4,12,-7,-17"
            });

            // Act
            int[,] matrix = ds.GetMatrix(path);

            // Assert
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // проверяем, что количество строк и столбцов корректно
            Assert.AreEqual(9, rows);
            Assert.AreEqual(10, cols);

            // проверяем выборочные замены во втором столбце (индекс 1)
            // 1-я строка: 9 -> 222 (т.к. >5)
            Assert.AreEqual(222, matrix[0, 1]);

            // 3-я строка: 7 -> 222 (т.к. >5)
            Assert.AreEqual(222, matrix[2, 1]);

            // 4-я строка: -1 -> -1 (<=5, не меняем)
            Assert.AreEqual(-1, matrix[3, 1]);

            // 5-я строка: 17 -> 222 (т.к. >5)
            Assert.AreEqual(222, matrix[4, 1]);

            // первая колонка (индекс 0) — не должна меняться
            Assert.AreEqual(19, matrix[0, 0]);
            Assert.AreEqual(-17, matrix[2, 0]);

            // последний столбец (idx=9) — не затронут
            Assert.AreEqual(-2, matrix[0, 9]);
            Assert.AreEqual(-17, matrix[8, 9]);
        }
    }
}