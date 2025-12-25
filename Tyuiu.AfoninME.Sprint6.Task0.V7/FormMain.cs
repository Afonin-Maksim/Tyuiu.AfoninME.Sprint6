using System;
using System.Windows.Forms;
using Tyuiu.AfoninME.Sprint6.Task0.V7.Lib;

namespace Tyuiu.AfoninME.Sprint6.Task0.V7
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
            try
            {
                // значение X фиксировано по условию задания
                int x = 3;
                double result = ds.Calculate(x);
                textBoxResult_AfoninME.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка вычисления: " + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_AfoninME_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Задание 0 | Вариант 7\n" +
                            "Вычислить значение выражения:\n" +
                            "y = (x?) / (2(x+5)?) при x = 3",
                            "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}