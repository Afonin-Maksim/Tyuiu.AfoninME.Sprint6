using System;
using System.Globalization;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AfoninME.Sprint6.Task7.V26.Lib
{
    public class DataService: ISprint6Task7V26
    {
        
        public int[,] GetMatrix(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден!", path);

            string[] lines = File.ReadAllLines(path)
                                 .Where(l => !string.IsNullOrWhiteSpace(l))
                                 .ToArray();

            // Находим максимальное количество элементов в строках,
            // чтобы выровнять "кривые" строки и избежать сдвигов
            int cols = lines.Max(l => l
                .Split(new char[] { ' ', '\t', ';', ',' },
                     StringSplitOptions.RemoveEmptyEntries).Length);
            int rows = lines.Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] parts = lines[i]
                    .Split(new char[] { ' ', '\t', ';', ',' },
                           StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < cols; j++)
                {
                    int val = 0;
                    if (j < parts.Length)
                        int.TryParse(parts[j], NumberStyles.Integer, CultureInfo.InvariantCulture, out val);
                    matrix[i, j] = val;
                }
            }

            return matrix; // Возвращаем исходную, без изменений
        }

        // --- Старые имена для совместимости тестов ---
        public int[,] LoadMatrix(string path) => GetMatrix(path);

        public int[,] ProcessMatrix(int[,] source)
        {
            int rows = source.GetLength(0);
            int cols = source.GetLength(1);
            int[,] result = new int[rows, cols];

            // копируем исходную матрицу
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = source[i, j];

            // обработка: замена во втором столбце (индекс 1)
            if (cols > 1)
            {
                for (int i = 0; i < rows; i++)
                {
                    if (result[i, 1] > 5)
                        result[i, 1] = 222;
                }
            }

            return result;
        }
    }
}