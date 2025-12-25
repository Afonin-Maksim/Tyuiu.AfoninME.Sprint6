using System;
using System.Globalization;
using System.IO;

namespace Tyuiu.AfoninME.Sprint6.Task7.V26.Lib
{
    public class DataService
    {
        public int[,] GetMatrix(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден.", path);

            // Читаем все строки
            string[] lines = File.ReadAllLines(path);

            // Определяем размерность матрицы по первой строке
            string[] first = lines[0].Split(new char[] { ';', ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int cols = first.Length;

            int[,] matrix = new int[rows, cols];

            // 1️⃣ Сначала формируем матрицу
            for (int i = 0; i < rows; i++)
            {
                string[] parts = lines[i].Split(new char[] { ';', ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < cols; j++)
                {
                    int val = 0;
                    if (j < parts.Length)
                    {
                        _ = int.TryParse(parts[j], NumberStyles.Integer, CultureInfo.InvariantCulture, out val);
                    }

                    matrix[i, j] = val;
                }
            }

            // 2️⃣ Потом корректируем данные — только второй столбец (индекс 1)
            for (int i = 0; i < rows; i++)
            {
                if (cols > 1 && matrix[i, 1] > 5)
                {
                    matrix[i, 1] = 222;
                }
            }

            return matrix;
        }

        // Дополнительно — сохранение результата (для WinForms)
        public void SaveMatrix(string path, int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            string[] lines = new string[rows];

            for (int i = 0; i < rows; i++)
            {
                string[] values = new string[cols];
                for (int j = 0; j < cols; j++)
                {
                    values[j] = matrix[i, j].ToString(CultureInfo.InvariantCulture);
                }
                lines[i] = string.Join(";", values);
            }

            File.WriteAllLines(path, lines);
        }
    }
}