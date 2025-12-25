using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AfoninME.Sprint6.Task5.V13.Lib;

namespace Tyuiu.AfoninME.Sprint6.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_ReturnsFilteredValues()
        {
            // создаём временный тестовый файл
            string tempPath = Path.Combine(Path.GetTempPath(), "inputV13.txt");
            File.WriteAllText(tempPath, "-13 -19 -9.82 13 11.49 -9.71 3.36 10 14.52 16 13.66 0.48 4.13 -0.11 19 -17.36 11 11.28 -12 -12.35");

            DataService ds = new DataService();
            double[] actual = ds.LoadFromDataFile(tempPath);

            // должно вернуть только значения меньше 10, округлённые до 3 знаков
            double[] expected = { -13, -19, -9.82, -9.71, 3.36, 0.48, 4.13, -0.11, -17.36, -12, -12.35 };
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}