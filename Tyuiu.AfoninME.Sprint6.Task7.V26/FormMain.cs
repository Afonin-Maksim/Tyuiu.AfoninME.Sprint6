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
                "Необходимо заменить во втором столбце положительные значения больше 5 на 222.\r\n" +
                "Исходные данные вывести слева, результат обработки — справа.";
        }

        // === Открыть файл ===
        private void buttonOpenFile_AME_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "CSV файлы|*.csv|Все файлы|*.*";
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    matrixOriginal = ds.GetMatrix(openDialog.FileName);
                    matrixProcessed = null;

                    // показываем исходные данные слева
                    ShowMatrix_AME(matrixOriginal, dataGridViewIn_AME);

                    // очищаем таблицу справа
                    dataGridViewOut_AME.Rows.Clear();
                    dataGridViewOut_AME.Columns.Clear();
                }
            }
        }

        // === Обработать (замена во втором столбце >5 -> 222) ===
        private void buttonProcess_AME_Click(object sender, EventArgs e)
        {
            if (matrixOriginal == null)
            {
                MessageBox.Show("Сначала загрузите файл!");
                return;
            }

            int rows = matrixOriginal.GetLength(0);
            int cols = matrixOriginal.GetLength(1);
            matrixProcessed = new int[rows, cols];

            // копируем исходную матрицу в новую
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    matrixProcessed[i, j] = matrixOriginal[i, j];

                // корректируем второй столбец
                if (cols > 1 && matrixProcessed[i, 1] > 5)
                    matrixProcessed[i, 1] = 222;
            }

            // показываем результат справа
            ShowMatrix_AME(matrixProcessed, dataGridViewOut_AME);
        }

        // === Сохранение результата ===
        private void buttonSaveFile_AME_Click(object sender, EventArgs e)
        {
            if (matrixProcessed == null)
            {
                MessageBox.Show("Нет данных для сохранения!");
                return;
            }

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "CSV файлы|*.csv|Все файлы|*.*";
                if (saveDialog.ShowDialog() == DialogResult.OK)
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

                    File.WriteAllLines(saveDialog.FileName, lines);
                    MessageBox.Show("Файл успешно сохранён!");
                }
            }
        }

        // === О программе ===
        private void buttonAbout_AME_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        // === Метод показа матрицы ===
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
                string[] row = new string[cols];
                for (int c = 0; c < cols; c++)
                    row[c] = matrix[r, c].ToString();
                grid.Rows.Add(row);
            }

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // === Адаптивное расположение ===
        private void FormMain_Resize(object sender, EventArgs e)
        {
            int margin = 20;
            int textHeight = (int)(this.ClientSize.Height * 0.15);
            int space = 20;
            int buttonHeight = 40;

            textBoxCondition_AME.SetBounds(margin, margin,
                this.ClientSize.Width - 2 * margin, textHeight);

            int gridTop = margin + textBoxCondition_AME.Height + margin;
            int gridHeight = this.ClientSize.Height - gridTop - buttonHeight - (3 * margin);
            int gridWidth = (this.ClientSize.Width - (2 * margin) - space) / 2;

            dataGridViewIn_AME.SetBounds(margin, gridTop, gridWidth, gridHeight);
            dataGridViewOut_AME.SetBounds(margin + gridWidth + space, gridTop, gridWidth, gridHeight);

            int totalButtonsWidth = buttonOpenFile_AME.Width + buttonProcess_AME.Width +
                                    buttonSaveFile_AME.Width + buttonAbout_AME.Width + 3 * 10;
            int leftOffset = (this.ClientSize.Width - totalButtonsWidth) / 2;
            int top = this.ClientSize.Height - buttonHeight - margin;

            buttonOpenFile_AME.Top = top;
            buttonProcess_AME.Top = top;
            buttonSaveFile_AME.Top = top;
            buttonAbout_AME.Top = top;

            buttonOpenFile_AME.Left = leftOffset;
            buttonProcess_AME.Left = buttonOpenFile_AME.Right + 10;
            buttonSaveFile_AME.Left = buttonProcess_AME.Right + 10;
            buttonAbout_AME.Left = buttonSaveFile_AME.Right + 10;
        }
    }
}