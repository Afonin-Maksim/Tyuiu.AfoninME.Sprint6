using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AfoninME.Sprint6.Task6.V10.Lib
{
    public class DataService : ISprint6Task6V10
    {
        // Вариант 10.
        // Метод получает путь к файлу и возвращает все слова,
        // содержащие хотя бы одну строчную 'w' и не содержащие заглавной 'W'.
        public string CollectTextFromFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден: " + path);

            string text = File.ReadAllText(path);

            // Разделяем текст на слова
            string[] words = text.Split(
                new char[] { ' ', '\t', '\r', '\n', ',', '.', ';', ':', '!', '?', '-', '(', ')', '[', ']', '"' },
                StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                // включаем слово, если в нем есть 'w' (строчная)
                // и полностью НЕТ заглавной 'W'
                if (word.Contains('w') && !word.Contains('W'))
                {
                    result.Append(word + " ");
                }
            }

            return result.ToString().TrimEnd();
        }
    }
}