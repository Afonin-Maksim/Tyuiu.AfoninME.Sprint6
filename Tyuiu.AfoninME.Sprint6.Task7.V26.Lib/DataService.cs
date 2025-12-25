using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Tyuiu.AfoninME.Sprint6.Task7.V26.Lib
{
    public class DataService
    {
        public int[,] GetMatrix(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден", path);

            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;
            int cols = lines[0].Split(';', ',', ' ', '\t').Length;

            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] parts = lines[i]
                    .Split(new char[] { ';', ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < cols; j++)
                    matrix[i, j] = int.Parse(parts[j], CultureInfo.InvariantCulture);
            }

            // Второй столбец — j == 1! Корректируем только его
            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, 1] > 5)
                    matrix[i, 1] = 222;
            }

            return matrix;
        }
    }
}