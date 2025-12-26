using System;
using System.Globalization;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AfoninME.Sprint6.Task7.V26.Lib
{
    public class DataService : ISprint6Task7V26
    {
        // Чтение матрицы из файла
        public int[,] GetMatrix(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден.", path);

            string[] lines = File.ReadAllLines(path)
                                 .Where(l => !string.IsNullOrWhiteSpace(l))
                                 .ToArray();

            int rows = lines.Length;
            int cols = lines[0]
                .Split(new char[] { ' ', '\t', ';', ',' },
                       StringSplitOptions.RemoveEmptyEntries).Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] parts = lines[i].Split(new char[] { ' ', '\t', ';', ',' },
                                                StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < parts.Length; j++)
                {
                    matrix[i, j] = int.Parse(parts[j],
                                  NumberStyles.Integer,
                                  CultureInfo.InvariantCulture);
                }
            }

            return matrix;
        }

        // Обработка матрицы: замена значений > 5 во втором столбце на 222
        public int[,] ProcessMatrix(int[,] source)
        {
            int rows = source.GetLength(0);
            int cols = source.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = source[i, j];

            for (int i = 0; i < rows; i++)
            {
                if (result[i, 1] > 5)
                    result[i, 1] = 222;
            }

            return result;
        }

        // Вспомогательная обертка под тест, чтобы не ломать тестовые вызовы
        public int[,] LoadMatrix(string path)
        {
            return GetMatrix(path);
        }
    }
}