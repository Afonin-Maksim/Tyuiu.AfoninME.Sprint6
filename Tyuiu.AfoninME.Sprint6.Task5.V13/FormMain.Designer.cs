namespace Tyuiu.AfoninME.Sprint6.Task5.V13
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle_AfoninME = new System.Windows.Forms.Label();
            this.dataGridValues_AfoninME = new System.Windows.Forms.DataGridView();
            this.ColumnVal_AfoninME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBar_AfoninME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLoadFile_AfoninME = new System.Windows.Forms.Button();
            this.buttonHelp_AfoninME = new System.Windows.Forms.Button();
            this.labelCount_AfoninME = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridValues_AfoninME)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle_AfoninME
            // 
            this.labelTitle_AfoninME.AutoSize = true;
            this.labelTitle_AfoninME.Location = new System.Drawing.Point(20, 20);
            this.labelTitle_AfoninME.Name = "labelTitle_AfoninME";
            this.labelTitle_AfoninME.Size = new System.Drawing.Size(370, 13);
            this.labelTitle_AfoninME.TabIndex = 0;
            this.labelTitle_AfoninME.Text = "Чтение чисел из файла C:\\DataSprint6\\InPutFileTask5V13.txt (меньше 10)";
            // 
            // dataGridValues_AfoninME
            // 
            this.dataGridValues_AfoninME.AllowUserToAddRows = false;
            this.dataGridValues_AfoninME.AllowUserToDeleteRows = false;
            this.dataGridValues_AfoninME.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridValues_AfoninME.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.ColumnVal_AfoninME,
                this.ColumnBar_AfoninME});
            this.dataGridValues_AfoninME.Location = new System.Drawing.Point(23, 50);
            this.dataGridValues_AfoninME.Name = "dataGridValues_AfoninME";
            this.dataGridValues_AfoninME.ReadOnly = true;
            this.dataGridValues_AfoninME.RowHeadersVisible = false;
            this.dataGridValues_AfoninME.Size = new System.Drawing.Size(380, 200);
            this.dataGridValues_AfoninME.TabIndex = 1;
            // 
            // ColumnVal_AfoninME
            // 
            this.ColumnVal_AfoninME.HeaderText = "Значение";
            this.ColumnVal_AfoninME.Name = "ColumnVal_AfoninME";
            this.ColumnVal_AfoninME.ReadOnly = true;
            this.ColumnVal_AfoninME.Width = 90;
            // 
            // ColumnBar_AfoninME
            // 
            this.ColumnBar_AfoninME.HeaderText = "Псевдодиаграмма";
            this.ColumnBar_AfoninME.Name = "ColumnBar_AfoninME";
            this.ColumnBar_AfoninME.ReadOnly = true;
            this.ColumnBar_AfoninME.Width = 250;
            // 
            // buttonLoadFile_AfoninME
            // 
            this.buttonLoadFile_AfoninME.Location = new System.Drawing.Point(420, 50);
            this.buttonLoadFile_AfoninME.Name = "buttonLoadFile_AfoninME";
            this.buttonLoadFile_AfoninME.Size = new System.Drawing.Size(100, 25);
            this.buttonLoadFile_AfoninME.TabIndex = 2;
            this.buttonLoadFile_AfoninME.Text = "Загрузить";
            this.buttonLoadFile_AfoninME.UseVisualStyleBackColor = true;
            this.buttonLoadFile_AfoninME.Click +=
                new System.EventHandler(this.buttonLoadFile_AfoninME_Click);
            // 
            // buttonHelp_AfoninME
            // 
            this.buttonHelp_AfoninME.Location = new System.Drawing.Point(420, 90);
            this.buttonHelp_AfoninME.Name = "buttonHelp_AfoninME";
            this.buttonHelp_AfoninME.Size = new System.Drawing.Size(30, 25);
            this.buttonHelp_AfoninME.TabIndex = 3;
            this.buttonHelp_AfoninME.Text = "?";
            this.buttonHelp_AfoninME.UseVisualStyleBackColor = true;
            this.buttonHelp_AfoninME.Click +=
                new System.EventHandler(this.buttonHelp_AfoninME_Click);
            // 
            // labelCount_AfoninME
            // 
            this.labelCount_AfoninME.AutoSize = true;
            this.labelCount_AfoninME.Location = new System.Drawing.Point(23, 265);
            this.labelCount_AfoninME.Name = "labelCount_AfoninME";
            this.labelCount_AfoninME.Size = new System.Drawing.Size(95, 13);
            this.labelCount_AfoninME.TabIndex = 4;
            this.labelCount_AfoninME.Text = "Всего найдено: 0";
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(560, 300);
            this.Controls.Add(this.labelCount_AfoninME);
            this.Controls.Add(this.buttonHelp_AfoninME);
            this.Controls.Add(this.buttonLoadFile_AfoninME);
            this.Controls.Add(this.dataGridValues_AfoninME);
            this.Controls.Add(this.labelTitle_AfoninME);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Task 5 | Вариант 13 | Афонин М.Е.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridValues_AfoninME)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle_AfoninME;
        private System.Windows.Forms.DataGridView dataGridValues_AfoninME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVal_AfoninME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBar_AfoninME;
        private System.Windows.Forms.Button buttonLoadFile_AfoninME;
        private System.Windows.Forms.Button buttonHelp_AfoninME;
        private System.Windows.Forms.Label labelCount_AfoninME;
    }
}