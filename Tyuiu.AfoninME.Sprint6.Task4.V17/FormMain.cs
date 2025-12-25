using System;
using System.Windows.Forms;
using Tyuiu.AfoninME.Sprint6.Task4.V17.Lib;

namespace Tyuiu.AfoninME.Sprint6.Task4.V17
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCalculate_AfoninME_Click(object sender, EventArgs e)
        {
            int startValue = -5;
            int stopValue = 5;
            double[] results = ds.GetMassFunction(startValue, stopValue);
            DisplayResults(results, startValue);
        }

        private void DisplayResults(double[] results, int start)
        {
            dataGridResult_AfoninME.Rows.Clear();
            int x = start;

            foreach (double fx in results)
            {
                dataGridResult_AfoninME.Rows.Add(x, fx);
                x++;
            }
        }

        private void buttonSave_AfoninME_Click(object sender, EventArgs e)
        {
            int start = -5;
            int stop = 5;
            double[] values = ds.GetMassFunction(start, stop);
            string path = ds.SaveToFileTxt(values, start, stop);
            MessageBox.Show("Результат сохранён:\n" + path, "Сохранение",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonHelp_AfoninME_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Задание 4 | Вариант 17\n" +
                            "F(x) = (sin(x)/(x+1.7)) - cos(x)*4x - 6\n" +
                            "x ∈ [-5;5], шаг 1\n" +
                            "Результат выводится в таблицу и сохраняется в OutPutFileTask4V17.txt.",
                            "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}