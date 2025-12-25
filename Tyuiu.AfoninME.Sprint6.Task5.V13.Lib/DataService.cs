using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AfoninME.Sprint6.Task5.V13.Lib
{
    public class DataService : ISprint6Task5V13
    {
        // Вариант 13: Прочитать данные из файла InPutFileTask5V13.txt
        // Выбрать все числа, меньшие 10. У вещественных значений — округление до 3 знаков.
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден: " + path);

            List<double> values = new List<double>();

            foreach (string line in File.ReadAllLines(path))
            {
                // Запятую не трогаем — она используется как десятичный разделитель в числе!
                string[] parts = line.Split(new char[] { ' ', '\t', ';' },
                                            StringSplitOptions.RemoveEmptyEntries);

                foreach (string raw in parts)
                {
                    // заменяем возможные запятые в числе на точки, чтобы Double.Parse их понял
                    string normalized = raw.Replace(',', '.');

                    if (double.TryParse(normalized, NumberStyles.Any,
                                        CultureInfo.InvariantCulture, out double num))
                    {
                        if (num < 10)
                        {
                            num = Math.Round(num, 3);
                            values.Add(num);
                        }
                    }
                }
            }

            return values.ToArray();
        }
    }
}