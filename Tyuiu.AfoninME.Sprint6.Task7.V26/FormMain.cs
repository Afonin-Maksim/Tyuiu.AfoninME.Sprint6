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

            // При запуске окно находится в центре экрана
            this.StartPosition = FormStartPosition.CenterScreen;

            // Текст условия (заполняется один раз при старте)
            textBoxCondition_AME.Text =
                "УСЛОВИЕ:\r\n" +
                "Дан файл InPutFileTask7V26.csv, в котором хранится матрица целых чисел.\r\n" +
                "Необходимо заменить во втором столбце положительные значения больше 5 на 222.\r\n" +
                "Результат вывести во вторую таблицу и сохранить в OutPutFileTask7V26.csv.";
        }

        // === Открытие файла ===
        private void buttonOpenFile_AME_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "CSV файлы|*.csv|Все файлы|*.*";
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    matrixOriginal = ds.GetMatrix(openDialog.FileName);
                    matrixProcessed = null;

                    ShowMatrix_AME(matrixOriginal, dataGridViewIn_AME);
                    dataGridViewOut_AME.Rows.Clear();
                    dataGridViewOut_AME.Columns.Clear();

                    this.Text = $"Спринт #6 | Task 7 | Вариант 26 | Афонин М.Е. | Файл: {openDialog.SafeFileName}";
                }
            }
        }

        // === Обработка данных ===
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
            Array.Copy(matrixOriginal, matrixProcessed, matrixOriginal.Length);

            for (int i = 0; i < rows; i++)
            {
                if (cols > 1 && matrixProcessed[i, 1] > 5)
                    matrixProcessed[i, 1] = 222;
            }

            ShowMatrix_AME(matrixProcessed, dataGridViewOut_AME);
        }

        // === Сохранение результата ===
        private void buttonSaveFile_AME_Click(object sender, EventArgs e)
        {
            if (matrixProcessed == null)
            {
                MessageBox.Show("Нет обработанных данных для сохранения!");
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
                    MessageBox.Show("Результат успешно сохранён!");
                }
            }
        }

        // === О программе ===
        private void buttonAbout_AME_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        // === Отображение матрицы ===
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

        // === Адаптивная верстка при изменении размеров окна ===
        private void FormMain_Resize(object sender, EventArgs e)
        {
            int margin = 20;
            int buttonHeight = 40;
            int space = 20;

            // Высота поля с заданием (15% высоты окна)
            int textHeight = (int)(this.ClientSize.Height * 0.15);
            textBoxCondition_AME.SetBounds(margin, margin,
                this.ClientSize.Width - 2 * margin, textHeight);

            // Расчёт таблиц
            int gridTop = margin + textBoxCondition_AME.Height + margin;
            int gridHeight = this.ClientSize.Height - gridTop - buttonHeight - (3 * margin);
            int gridWidth = (this.ClientSize.Width - (2 * margin) - space) / 2;

            dataGridViewIn_AME.SetBounds(margin, gridTop, gridWidth, gridHeight);
            dataGridViewOut_AME.SetBounds(margin + gridWidth + space, gridTop, gridWidth, gridHeight);

            // Кнопки внизу
            int buttonsWidth = buttonOpenFile_AME.Width + buttonProcess_AME.Width +
                               buttonSaveFile_AME.Width + buttonAbout_AME.Width + 3 * 10;
            int buttonsLeft = (this.ClientSize.Width - buttonsWidth) / 2;
            int buttonsTop = this.ClientSize.Height - buttonHeight - margin;

            buttonOpenFile_AME.Top = buttonProcess_AME.Top = buttonSaveFile_AME.Top =
                buttonAbout_AME.Top = buttonsTop;

            buttonOpenFile_AME.Left = buttonsLeft;
            buttonProcess_AME.Left = buttonOpenFile_AME.Right + 10;
            buttonSaveFile_AME.Left = buttonProcess_AME.Right + 10;
            buttonAbout_AME.Left = buttonSaveFile_AME.Right + 10;
        }
    }
}