using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AfoninME.Sprint6.Task6.V10.Lib;

namespace Tyuiu.AfoninME.Sprint6.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFile_WorksCorrectly()
        {
            // Создаем временный файл с тестовым содержимым
            string tempFile = Path.Combine(Path.GetTempPath(), "InputTestV10.txt");
            File.WriteAllText(tempFile,
                "We write awesome words with workflow. Sometimes Windows waits.");

            // Создаем объект и вызываем метод
            DataService ds = new DataService();
            string actual = ds.CollectTextFromFile(tempFile);

            // Ожидаемая строка: все слова с буквой 'w' или 'W'
            string expected = "write awesome words with workflow waits";

            Assert.AreEqual(expected, actual);
        }
    }
}