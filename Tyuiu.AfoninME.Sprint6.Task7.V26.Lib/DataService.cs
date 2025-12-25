using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AfoninME.Sprint6.Task7.V26.Lib
{
    public class DataService: ISprint6Task7V26
    {       
        public int[,] GetMatrix(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден!", path);

            string[] lines = File.ReadAllLines(path)
                                 .Where(l => !string.IsNullOrWhiteSpace(l))
                                 .ToArray();

            int rows = lines.Length;
            int cols = lines[0].Split(new char[] { ';', ',', ' ', '\t' },
                                      StringSplitOptions.RemoveEmptyEntries).Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] parts = lines[i]
                    .Split(new char[] { ';', ',', ' ', '\t' },
                           StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < cols; j++)
                {
                    int value = 0;
                    if (j < parts.Length)
                        int.TryParse(parts[j], NumberStyles.Integer, CultureInfo.InvariantCulture, out value);
                    matrix[i, j] = value;
                }
            }

            return matrix;
        }

        public int[,] LoadMatrix(string path)
        {
            return GetMatrix(path);
        }

        public int[,] ProcessMatrix(int[,] source)
        {
            int rows = source.GetLength(0);
            int cols = source.GetLength(1);
            int[,] result = new int[rows, cols];
            Array.Copy(source, result, source.Length);

            for (int i = 0; i < rows; i++)
            {
                if (cols > 1 && result[i, 1] > 5)
                    result[i, 1] = 222;
            }

            return result;
        }
    }
}