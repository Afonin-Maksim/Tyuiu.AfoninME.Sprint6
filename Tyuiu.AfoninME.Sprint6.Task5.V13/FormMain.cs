using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.AfoninME.Sprint6.Task5.V13.Lib;

namespace Tyuiu.AfoninME.Sprint6.Task5.V13
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string filePath = @"C:\DataSprint6\InPutFileTask5V13.txt";

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonLoadFile_AfoninME_Click(object sender, EventArgs e)
        {
            try
            {
                double[] numbers = ds.LoadFromDataFile(filePath);
                dataGridValues_AfoninME.Rows.Clear();

                foreach (double val in numbers)
                {
                    // псевдодиаграмма — столько #, сколько модуль числа
                    string bar = new string('#', Math.Min((int)Math.Round(Math.Abs(val)), 50));
                    dataGridValues_AfoninME.Rows.Add(val, bar);
                }

                labelCount_AfoninME.Text = $"Всего найдено: {numbers.Length}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_AfoninME_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Task 5 | Вариант 13\n" +
                            "Программа читает числа из файла C:\\DataSprint6\\InPutFileTask5V13.txt\n" +
                            "Выводит все значения меньше 10 без округления.\n" +
                            "Отображает псевдодиаграмму из символов '#'.",
                            "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}