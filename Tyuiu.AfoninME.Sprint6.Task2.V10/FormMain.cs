using System;
using System.Windows.Forms;
using Tyuiu.AfoninME.Sprint6.Task2.V10.Lib;

namespace Tyuiu.AfoninME.Sprint6.Task2.V10
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDoCalculate_AfoninME_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = -5;
                int stopValue = 5;

                double[] values = ds.GetMassFunction(startValue, stopValue);

                dataGridViewValues_AfoninME.Rows.Clear();

                int i = 0;
                for (int x = startValue; x <= stopValue; x++)
                {
                    dataGridViewValues_AfoninME.Rows.Add(x, values[i]);
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка вычислений: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_AfoninME_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Задание 2 | Вариант 10\n" +
                            "Табулирование функции:\n" +
                            "F(x) = 2x - 4 + (2x - 1) / (sin(x) + 1)\n" +
                            "x ∈ [-5; 5], шаг = 1\n" +
                            "Результаты выводятся в таблицу DataGridView.",
                            "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}