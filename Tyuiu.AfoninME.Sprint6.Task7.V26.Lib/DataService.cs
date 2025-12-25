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
                throw new FileNotFoundException("Файл не найден", path);

            string[] lines = File.ReadAllLines(path)
                                 .Where(l => !string.IsNullOrWhiteSpace(l))
                                 .ToArray();

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
            int[,] result = new int[rows, cols];
            Array.Copy(matrix, result, matrix.Length);

            for (int i = 0; i < rows; i++)
            {
                if (cols > 1 && result[i, 1] > 5)
                    result[i, 1] = 222;
            }

            return result;
        }

        public int[,] LoadMatrix(string path) => GetMatrix(path);
        public int[,] ProcessMatrix(int[,] src)
        {
            int r = src.GetLength(0);
            int c = src.GetLength(1);
            int[,] res = new int[r, c];
            Array.Copy(src, res, src.Length);
            for (int i = 0; i < r; i++)
                if (c > 1 && res[i, 1] > 5)
                    res[i, 1] = 222;
            return res;
        }
    }
}