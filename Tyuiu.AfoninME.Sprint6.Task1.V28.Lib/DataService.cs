using System;
using System.Collections.Generic;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AfoninME.Sprint6.Task1.V28.Lib
{
    public class DataService : ISprint6Task1V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] result = new double[length];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double fx = Math.Cos(x) + (4.0 * x / 2.0) - Math.Sin(x) * 3.0 * x;
                fx = Math.Round(fx, 2);
                result[index] = fx;
                index++;
            }

            return result;
        }
    }
}