using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.AfoninME.Sprint6.Task7.V26.Lib;

namespace Tyuiu.AfoninME.Sprint6.Task7.V26
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        int[,]? matrix;

        public FormMain()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.Resize += FormMain_Resize;

            // заполняем текст условия
            textBoxCondition_AME.Text =
                "УСЛОВИЕ:\r\n" +
                "Дан CSV-файл, содержащий матрицу целых чисел.\r\n" +
                "Необходимо заменить во втором столбце положительные значения больше 5 на 222.\r\n" +
                "Вывести исходную и изменённую матрицы, сохранить результат в новый файл.";
        }

        private void buttonOpenFile_AME_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "CSV-файлы|*.csv|Все файлы|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        matrix = ds.GetMatrix(dlg.FileName);
                        ShowMatrix(matrix, dataGridViewInput_AME);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonProcess_AME_Click(object sender, EventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("Сначала загрузите файл!");
                return;
            }

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int val = matrix[i, j];
                    if (j == 1 && val > 5)
                        result[i, j] = 222;
                    else
                        result[i, j] = val;
                }
            }

            ShowMatrix(result, dataGridViewOutput_AME);
            matrix = result;
        }

        private void buttonSaveFile_AME_Click(object sender, EventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("Нет данных для сохранения!");
                return;
            }

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "CSV-файлы|*.csv|Все файлы|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    int rows = matrix.GetLength(0);
                    int cols = matrix.GetLength(1);
                    string[] lines = new string[rows];
                    for (int i = 0; i < rows; i++)
                    {
                        string[] vals = new string[cols];
                        for (int j = 0; j < cols; j++)
                            vals[j] = matrix[i, j].ToString();
                        lines[i] = string.Join(",", vals);
                    }
                    File.WriteAllLines(dlg.FileName, lines);
                    MessageBox.Show("Файл успешно сохранён!");
                }
            }
        }

        private void ShowMatrix(int[,] data, DataGridView grid)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();

            int rows = data.GetLength(0);
            int cols = data.GetLength(1);
            for (int c = 0; c < cols; c++)
                grid.Columns.Add($"col{c}", $"Столбец {c + 1}");
            for (int r = 0; r < rows; r++)
            {
                string[] row = new string[cols];
                for (int c = 0; c < cols; c++)
                    row[c] = data[r, c].ToString();
                grid.Rows.Add(row);
            }

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Автоматическое расположение элементов
        private void FormMain_Resize(object sender, EventArgs e)
        {
            int margin = 20;
            int space = 20;
            int buttonHeight = 40;
            int textHeight = (int)(this.ClientSize.Height * 0.18); // 18% высоты под условие

            textBoxCondition_AME.SetBounds(margin, margin, this.ClientSize.Width - 2 * margin, textHeight);

            int gridWidth = (this.ClientSize.Width - (2 * margin) - space) / 2;
            int gridTop = margin + textBoxCondition_AME.Height + margin;
            int gridHeight = this.ClientSize.Height - gridTop - buttonHeight - (2 * margin);

            dataGridViewInput_AME.SetBounds(margin, gridTop, gridWidth, gridHeight);
            dataGridViewOutput_AME.SetBounds(margin + gridWidth + space, gridTop, gridWidth, gridHeight);

            int totalButtonsWidth = buttonOpenFile_AME.Width + buttonProcess_AME.Width +
                                    buttonSaveFile_AME.Width + buttonAbout_AME.Width + (3 * 15);
            int buttonsLeft = (this.ClientSize.Width - totalButtonsWidth) / 2;
            int buttonsTop = this.ClientSize.Height - buttonHeight - margin;

            buttonOpenFile_AME.Top = buttonsTop;
            buttonProcess_AME.Top = buttonsTop;
            buttonSaveFile_AME.Top = buttonsTop;
            buttonAbout_AME.Top = buttonsTop;

            buttonOpenFile_AME.Left = buttonsLeft;
            buttonProcess_AME.Left = buttonOpenFile_AME.Right + 15;
            buttonSaveFile_AME.Left = buttonProcess_AME.Right + 15;
            buttonAbout_AME.Left = buttonSaveFile_AME.Right + 15;
        }

        private void buttonAbout_AME_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }
    }
}