using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AfoninME.Sprint6.Task4.V17.Lib
{
    public class DataService : ISprint6Task4V17
    {
        // Метод табулирования функции:
        // F(x) = (sin(x)/(x + 1.7)) - cos(x) * 4x - 6
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] results = new double[length];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double fx;
                // Проверка деления на ноль → вернуть 0
                if (Math.Abs(x + 1.7) < 1e-10)
                {
                    fx = 0;
                }
                else
                {
                    fx = (Math.Sin(x) / (x + 1.7)) - Math.Cos(x) * 4 * x - 6;
                    fx = Math.Round(fx, 2);
                }

                results[index] = fx;
                index++;
            }

            return results;
        }

        // Сохранение результатов в файл C:\DataSprint6\OutPutFileTask4V17.txt
        public string SaveToFileTxt(double[] array, int startValue, int stopValue)
        {
            string folderPath = @"C:\DataSprint6";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = Path.Combine(folderPath, "OutPutFileTask4V17.txt");

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                int x = startValue;
                foreach (double fx in array)
                {
                    sw.WriteLine($"x={x,3}  f(x)={fx,6}");
                    x++;
                }
            }

            // Обязательно вернуть путь к файлу, чтобы метод использовался корректно
            return filePath;
        }
    }
}