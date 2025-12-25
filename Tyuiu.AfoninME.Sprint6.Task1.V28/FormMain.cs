using System;
using System.Windows.Forms;
using Tyuiu.AfoninME.Sprint6.Task1.V28.Lib;

namespace Tyuiu.AfoninME.Sprint6.Task1.V28
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

                double[] results = ds.GetMassFunction(startValue, stopValue);

                textBoxResult_AfoninME.Clear();

                textBoxResult_AfoninME.AppendText("x\tF(x)" + Environment.NewLine);
                int x = startValue;
                foreach (double val in results)
                {
                    textBoxResult_AfoninME.AppendText($"{x}\t{val}" + Environment.NewLine);
                    x++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка вычислений: " + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_AfoninME_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Задание 1 | Вариант 28\n" +
                            "Табулирование функции:\n" +
                            "F(x) = cos(x) + (4x / 2) - sin(x) * 3x\n" +
                            "x ? [-5; 5], шаг = 1",
                            "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}