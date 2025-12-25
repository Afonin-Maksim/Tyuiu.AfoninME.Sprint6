using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AfoninME.Sprint6.Task7.V26.Lib;

namespace Tyuiu.AfoninME.Sprint6.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMatrixValid()
        {
            // Arrange
            DataService ds = new DataService();

            string dir = Path.GetTempPath();
            string path = Path.Combine(dir, "InPutFileTask7V26.csv");

            File.WriteAllLines(path, new string[]
            {
                "1,2,3",
                "4,5,6",
                "7,8,9"
            });

            // Act
            int[,] matrix = ds.GetMatrix(path);

            // Assert
            Assert.AreEqual(1, matrix[0, 0]);
            Assert.AreEqual(5, matrix[1, 1]);
            Assert.AreEqual(9, matrix[2, 2]);
        }
    }
}