using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AfoninME.Sprint6.Task3.V5.Lib
{
    public class DataService : ISprint6Task3V5
    {
        // Сортировка только элементов в третьем столбце (индекс 2)
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Извлекаем значения 3-го столбца в отдельный массив
            int[] colValues = new int[rows];
            for (int i = 0; i < rows; i++)
                colValues[i] = matrix[i, 2];

            // Сортируем этот столбец по возрастанию
            Array.Sort(colValues);

            // Подставляем отсортированные значения обратно в 3-й столбец
            for (int i = 0; i < rows; i++)
                matrix[i, 2] = colValues[i];

            return matrix;
        }
    }
}