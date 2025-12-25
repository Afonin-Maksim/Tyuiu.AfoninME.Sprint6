using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.AfoninME.Sprint6.Task6.V10.Lib;

namespace Tyuiu.AfoninME.Sprint6.Task6.V10
{
    public partial class FormMain : Form
    {
        private string currentFilePath = string.Empty;
        private readonly DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_AfoninME_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Открыть текстовый файл";
            ofd.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = ofd.FileName;
                textBoxInput_AfoninME.Text = File.ReadAllText(currentFilePath);
                textBoxOutput_AfoninME.Clear();
            }
        }

        private void buttonProcess_AfoninME_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(currentFilePath))
                {
                    MessageBox.Show("Сначала выберите файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string result = ds.CollectTextFromFile(currentFilePath);
                textBoxOutput_AfoninME.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message,
                                "Ошибка выполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_AfoninME_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Задание 6 | Вариант 10\n\n" +
                "Программа загружает текстовый файл и выводит все слова, " +
                "в которых встречается латинская буква 'w' или 'W'.\n" +
                "Файл выбирается через стандартное диалоговое окно.",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}