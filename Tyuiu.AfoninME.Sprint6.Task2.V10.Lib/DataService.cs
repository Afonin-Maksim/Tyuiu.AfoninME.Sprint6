using System;
using System.Collections.Generic;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AfoninME.Sprint6.Task2.V10.Lib
{
    public class DataService : ISprint6Task2V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double fx;

                // Проверка деления на ноль: sin(x) + 1 ≠ 0
                if (Math.Abs(Math.Sin(x) + 1) < 1e-10)
                {
                    fx = 0;
                }
                else
                {
                    fx = 2 * x - 4 + ((2 * x - 1) / (Math.Sin(x) + 1));
                    fx = Math.Round(fx, 2);
                }

                result[index] = fx;
                index++;
            }

            return result;
        }
    }
}