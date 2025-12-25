using System;
using System.Windows.Forms;
using Tyuiu.AfoninME.Sprint6.Task3.V5.Lib;

namespace Tyuiu.AfoninME.Sprint6.Task3.V5
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        int[,] matrix =
        {
            { 30, -20,  7,  -8,  9 },
            { 32,  17, -14,  -7, 33 },
            { 19, -19, -13,  14, -20 },
            { 11,  30,  -1,  26,   6 },
            { 30, -15, -20,  -5,  15 }
        };

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PrintMatrix(matrix, dataGridViewInput_AfoninME);
        }

        private void buttonDoSort_AfoninME_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate((int[,])matrix.Clone());
            PrintMatrix(res, dataGridViewOutput_AfoninME);
        }

        private void PrintMatrix(int[,] matr, DataGridView grid)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();

            int rows = matr.GetLength(0);
            int cols = matr.GetLength(1);

            for (int c = 0; c < cols; c++)
                grid.Columns.Add($"col{c}", $"C{c + 1}");

            for (int r = 0; r < rows; r++)
            {
                grid.Rows.Add();
                for (int c = 0; c < cols; c++)
                    grid[c, r].Value = matr[r, c];
            }

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void buttonHelp_AfoninME_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Спринт 6 | Задание 3 | Вариант 5\n" +
                "Дан массив 5×5. Выполнить сортировку по возрастанию в третьем столбце.\n" +
                "Результат вывести в DataGridView.",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}