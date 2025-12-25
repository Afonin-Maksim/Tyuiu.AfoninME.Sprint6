using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.AfoninME.Sprint6.Task7.V26.Lib
{
    public class DataService: ISprint6Task7V26
    {
        /// <summary>
        /// Чтение CSV-файла, содержащего матрицу целочисленных значений.
        /// Каждая строка — новая строка матрицы, значения разделены запятыми.
        /// </summary>
        /// <param name="path">Путь к файлу CSV</param>
        /// <retuns>Двумерный массив int[,] с прочитанными данными</returns>
        public int[,] GetMatrix(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден!", path);

            // Читаем все строки
            string[] lines = File.ReadAllLines(path);

            // Определим размеры матрицы
            int rows = lines.Length;
            int cols = lines[0].Split(';', ',', '\t').Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] parts = lines[i]
                    .Split(new char[] { ';', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < cols; j++)
                {
                    if (int.TryParse(parts[j], out int value))
                        matrix[i, j] = value;
                    else
                        throw new FormatException($"Ошибка парсинга числа в строке {i + 1}, столбце {j + 1}");
                }
            }

            return matrix;
        }
    }
}