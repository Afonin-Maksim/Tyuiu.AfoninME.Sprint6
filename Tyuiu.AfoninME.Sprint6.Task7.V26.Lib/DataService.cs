using System;
using System.Globalization;
using System.IO;

namespace Tyuiu.AfoninME.Sprint6.Task7.V26.Lib
{
    public class DataService
    {
        /// <summary>
        /// Читает матрицу из CSV-файла и возвращает новую матрицу,
        /// где во втором столбце заменены положительные значения > 5 на 222.
        /// </summary>
        public int[,] GetMatrix(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден", path);

            string[] lines = File.ReadAllLines(path);

            // определяем размер матрицы
            int rows = lines.Length;
            int cols = lines[0]
                .Split(new char[] { ';', ' ', '\t', ',' },
                       StringSplitOptions.RemoveEmptyEntries)
                .Length;

            int[,] matrix = new int[rows, cols];

            // === читаем исходные значения ===
            for (int i = 0; i < rows; i++)
            {
                string[] parts = lines[i]
                    .Split(new char[] { ';', ' ', '\t', ',' },
                           StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < cols; j++)
                {
                    int val = 0;
                    if (j < parts.Length)
                        int.TryParse(parts[j], NumberStyles.Integer,
                            CultureInfo.InvariantCulture, out val);
                    matrix[i, j] = val;
                }
            }

            // === создаём результат с корректировкой второго столбца ===
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // если это второй столбец (j == 1) и число > 5, заменяем
                    if (j == 1 && matrix[i, j] > 5)
                        result[i, j] = 222;
                    else
                        result[i, j] = matrix[i, j];
                }
            }

            return result;
        }
    }
}