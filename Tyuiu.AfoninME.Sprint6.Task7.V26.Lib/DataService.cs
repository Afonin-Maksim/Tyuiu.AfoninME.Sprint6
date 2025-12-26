using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AfoninME.Sprint6.Task7.V26.Lib
{
    public class DataService : ISprint6Task7V26
    {
        // Чтение матрицы из .csv
        public int[,] GetMatrix(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден.", path);

            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;
            string[] firstParts = lines[0].Split(new char[] { ';', ',' },
                                                 StringSplitOptions.RemoveEmptyEntries);
            int cols = firstParts.Length;
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] parts = lines[i].Split(new char[] { ';', ',' },
                                                StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < cols; j++)
                {
                    // если неверный формат — ставим 0
                    int.TryParse(parts[j].Trim(), NumberStyles.Integer,
                                 CultureInfo.InvariantCulture, out matrix[i, j]);
                }
            }
            return matrix;
        }

        // Для автопроверки
        public int[,] ProcessMatrix(string path)
        {
            int[,] m = GetMatrix(path);
            return ProcessMatrix(m);
        }

        // Для формы и тестов
        public int[,] ProcessMatrix(int[,] source)
        {
            int rows = source.GetLength(0);
            int cols = source.GetLength(1);
            int[,] res = new int[rows, cols];

            Array.Copy(source, res, source.Length);

            // менять именно второй столбец (индекс 1)
            for (int i = 0; i < rows; i++)
            {
                if (cols > 1 && res[i, 1] > 5)
                    res[i, 1] = 222;
            }
            return res;
        }

        public int[,] LoadMatrix(string path) => GetMatrix(path);
    }
}