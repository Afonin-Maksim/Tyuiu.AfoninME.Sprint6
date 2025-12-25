using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.AfoninME.Sprint6.Task7.V26.Lib;

namespace Tyuiu.AfoninME.Sprint6.Task7.V26
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        int[,]? matrixOriginal;
        int[,]? matrixProcessed;

        public FormMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Спринт #6 | Task 7 | Вариант 26 | Афонин М.Е.";

            textBoxCondition_AME.Text =
                "УСЛОВИЕ:\r\n" +
                "Дан файл InPutFileTask7V26.csv, в котором хранится матрица целых чисел.\r\n" +
                "Во втором столбце заменить положительные значения больше 5 на 222.\r\n" +
                "Исходная матрица отображается слева, результат обработки — справа.";
        }

        private void buttonOpenFile_AME_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "CSV файлы|*.csv|Все файлы|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    matrixOriginal = ds.GetMatrix(dlg.FileName);
                    matrixProcessed = null;

                    ShowMatrix_AME(matrixOriginal, dataGridViewIn_AME);
                    dataGridViewOut_AME.Rows.Clear();
                    dataGridViewOut_AME.Columns.Clear();
                }
            }
        }

        private void buttonProcess_AME_Click(object sender, EventArgs e)
        {
            if (matrixOriginal == null)
            {
                MessageBox.Show("Сначала загрузите файл!");
                return;
            }

            matrixProcessed = ds.ProcessMatrix(matrixOriginal);
            ShowMatrix_AME(matrixProcessed, dataGridViewOut_AME);
        }

        private void buttonSaveFile_AME_Click(object sender, EventArgs e)
        {
            if (matrixProcessed == null)
            {
                MessageBox.Show("Нет данных для сохранения!");
                return;
            }

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "CSV файлы|*.csv|Все файлы|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    int rows = matrixProcessed.GetLength(0);
                    int cols = matrixProcessed.GetLength(1);
                    string[] lines = new string[rows];

                    for (int i = 0; i < rows; i++)
                    {
                        string[] values = new string[cols];
                        for (int j = 0; j < cols; j++)
                            values[j] = matrixProcessed[i, j].ToString();
                        lines[i] = string.Join(";", values);
                    }

                    File.WriteAllLines(dlg.FileName, lines);
                    MessageBox.Show("Результат успешно сохранён!");
                }
            }
        }

        private void buttonAbout_AME_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private void ShowMatrix_AME(int[,] matrix, DataGridView grid)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int c = 0; c < cols; c++)
                grid.Columns.Add($"col{c}_AME", $"Столбец {c + 1}");

            for (int r = 0; r < rows; r++)
            {
                string[] rowData = new string[cols];
                for (int c = 0; c < cols; c++)
                    rowData[c] = matrix[r, c].ToString();
                grid.Rows.Add(rowData);
            }

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}