using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.AfoninME.Sprint6.Task7.V26.Lib;

namespace Tyuiu.AfoninME.Sprint6.Task7.V26
{
    public partial class FormMain : Form
    {
        private readonly DataService ds = new DataService();
        private int[,]? matrixOriginal;
        private int[,]? matrixProcessed;

        public FormMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Спринт #6 | Task 7 | Вариант 26 | Афонин М.Е.";

        }

        private void buttonOpenFile_AME_Click(object? sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "CSV файлы|*.csv|Все файлы|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string path = dlg.FileName;

                    // 1. Читаем файл как есть — без обработки, для вывода слева
                    string[] lines = File.ReadAllLines(path);
                    int rows = lines.Length;
                    int cols = lines[0].Split(';').Length;
                    matrixOriginal = new int[rows, cols];

                    for (int r = 0; r < rows; r++)
                    {
                        string[] parts = lines[r].Split(';');
                        for (int c = 0; c < cols; c++)
                            matrixOriginal[r, c] = Convert.ToInt32(parts[c]);
                    }

                    // 2. Показываем оригинальную матрицу слева
                    ShowMatrix_AME(matrixOriginal, dataGridViewIn_AME);

                    // 3. Правое поле очищаем
                    dataGridViewOut_AME.Rows.Clear();
                    dataGridViewOut_AME.Columns.Clear();
                    matrixProcessed = null;

                    // 4. Сохраняем путь к открытому файлу
                    buttonProcess_AME.Tag = path;

                    this.Text = $"Спринт #6 | Task 7 | Вариант 26 | Афонин М.Е. | Файл: {Path.GetFileName(path)}";
                }
            }
        }

        private void buttonProcess_AME_Click(object? sender, EventArgs e)
        {
            if (buttonProcess_AME.Tag == null)
            {
                MessageBox.Show("Сначала загрузите файл!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Вызываем библиотеку для обработки и отображаем результат справа
            string path = buttonProcess_AME.Tag.ToString();
            matrixProcessed = ds.GetMatrix(path);
            ShowMatrix_AME(matrixProcessed, dataGridViewOut_AME);
        }

        private void buttonSaveFile_AME_Click(object? sender, EventArgs e)
        {
            if (matrixProcessed == null)
            {
                MessageBox.Show("Нет данных для сохранения!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        string[] vals = new string[cols];
                        for (int j = 0; j < cols; j++)
                            vals[j] = matrixProcessed[i, j].ToString();
                        lines[i] = string.Join(";", vals);
                    }

                    File.WriteAllLines(dlg.FileName, lines);
                    MessageBox.Show($"Результат успешно сохранён:\n{dlg.FileName}",
                        "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonAbout_AME_Click(object? sender, EventArgs e)
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
                string[] rowVals = new string[cols];
                for (int c = 0; c < cols; c++)
                    rowVals[c] = matrix[r, c].ToString();
                grid.Rows.Add(rowVals);
            }

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormMain_Resize(object? sender, EventArgs e)
        {
            int margin = 20;
            int textHeight = (int)(this.ClientSize.Height * 0.15);
            int space = 20;
            int buttonHeight = 40;

            textBoxCondition_AME.SetBounds(margin, margin,
                this.ClientSize.Width - 2 * margin, textHeight);

            int gridTop = margin + textBoxCondition_AME.Height + margin;
            int gridHeight = this.ClientSize.Height - gridTop - buttonHeight - (4 * margin);
            int gridWidth = (this.ClientSize.Width - (2 * margin) - space) / 2;

            dataGridViewIn_AME.SetBounds(margin, gridTop, gridWidth, gridHeight);
            dataGridViewOut_AME.SetBounds(margin + gridWidth + space, gridTop, gridWidth, gridHeight);

            int totalWidth = buttonOpenFile_AME.Width + buttonProcess_AME.Width +
                             buttonSaveFile_AME.Width + buttonAbout_AME.Width + (3 * 10);
            int left = (this.ClientSize.Width - totalWidth) / 2;
            int top = this.ClientSize.Height - buttonHeight - margin;

            buttonOpenFile_AME.Top = buttonProcess_AME.Top =
                buttonSaveFile_AME.Top = buttonAbout_AME.Top = top;

            buttonOpenFile_AME.Left = left;
            buttonProcess_AME.Left = buttonOpenFile_AME.Right + 10;
            buttonSaveFile_AME.Left = buttonProcess_AME.Right + 10;
            buttonAbout_AME.Left = buttonSaveFile_AME.Right + 10;
        }

        private void dataGridViewIn_AME_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}