using System;
using System.Globalization;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AfoninME.Sprint6.Task7.V26.Lib
{
    public class DataService: ISprint6Task7V26
    {
        /// <summary>
        /// Считывает матрицу целых чисел из CSV-файла и возвращает исходные данные без изменений.
        /// </summary>
        public int[,] GetMatrix(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден!", path);

            string[] lines = File.ReadAllLines(path)
                                 .Where(l => !string.IsNullOrWhiteSpace(l))
                                 .ToArray();

            int cols = lines[0].Split(new char[] { ';', ',', ' ', '\t' },
                                      StringSplitOptions.RemoveEmptyEntries).Length;
            int rows = lines.Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] parts = lines[i]
                    .Split(new char[] { ';', ',', ' ', '\t' },
                           StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < cols; j++)
                {
                    int value = 0;
                    if (j < parts.Length)
                        int.TryParse(parts[j], NumberStyles.Integer, CultureInfo.InvariantCulture, out value);
                    matrix[i, j] = value;
                }
            }

            return matrix;
        }
    }
}