namespace Tyuiu.AfoninME.Sprint6.Task7.V26
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Designer

        private void InitializeComponent()
        {
            this.textBoxCondition_AME = new System.Windows.Forms.TextBox();
            this.dataGridViewInput_AME = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutput_AME = new System.Windows.Forms.DataGridView();
            this.buttonOpenFile_AME = new System.Windows.Forms.Button();
            this.buttonProcess_AME = new System.Windows.Forms.Button();
            this.buttonSaveFile_AME = new System.Windows.Forms.Button();
            this.buttonAbout_AME = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_AME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_AME)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCondition_AME
            // 
            this.textBoxCondition_AME.Multiline = true;
            this.textBoxCondition_AME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCondition_AME.ReadOnly = true;
            this.textBoxCondition_AME.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCondition_AME.Location = new System.Drawing.Point(12, 12);
            this.textBoxCondition_AME.Name = "textBoxCondition_AME";
            this.textBoxCondition_AME.Size = new System.Drawing.Size(840, 80);
            this.textBoxCondition_AME.TabIndex = 0;
            // 
            // dataGridViewInput_AME
            // 
            this.dataGridViewInput_AME.AllowUserToAddRows = false;
            this.dataGridViewInput_AME.AllowUserToDeleteRows = false;
            this.dataGridViewInput_AME.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInput_AME.Location = new System.Drawing.Point(12, 100);
            this.dataGridViewInput_AME.Name = "dataGridViewInput_AME";
            this.dataGridViewInput_AME.ReadOnly = true;
            this.dataGridViewInput_AME.Size = new System.Drawing.Size(400, 180);
            // 
            // dataGridViewOutput_AME
            // 
            this.dataGridViewOutput_AME.AllowUserToAddRows = false;
            this.dataGridViewOutput_AME.AllowUserToDeleteRows = false;
            this.dataGridViewOutput_AME.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOutput_AME.Location = new System.Drawing.Point(430, 100);
            this.dataGridViewOutput_AME.Name = "dataGridViewOutput_AME";
            this.dataGridViewOutput_AME.ReadOnly = true;
            this.dataGridViewOutput_AME.Size = new System.Drawing.Size(400, 180);
            // 
            // buttonOpenFile_AME
            // 
            this.buttonOpenFile_AME.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonOpenFile_AME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonOpenFile_AME.Text = "Открыть файл";
            this.buttonOpenFile_AME.Location = new System.Drawing.Point(80, 300);
            this.buttonOpenFile_AME.Size = new System.Drawing.Size(160, 40);
            this.buttonOpenFile_AME.Click += new System.EventHandler(this.buttonOpenFile_AME_Click);
            // 
            // buttonProcess_AME
            // 
            this.buttonProcess_AME.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonProcess_AME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonProcess_AME.Text = "Обработать";
            this.buttonProcess_AME.Location = new System.Drawing.Point(270, 300);
            this.buttonProcess_AME.Size = new System.Drawing.Size(160, 40);
            this.buttonProcess_AME.Click += new System.EventHandler(this.buttonProcess_AME_Click);
            // 
            // buttonSaveFile_AME
            // 
            this.buttonSaveFile_AME.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSaveFile_AME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSaveFile_AME.Text = "Сохранить";
            this.buttonSaveFile_AME.Location = new System.Drawing.Point(460, 300);
            this.buttonSaveFile_AME.Size = new System.Drawing.Size(160, 40);
            this.buttonSaveFile_AME.Click += new System.EventHandler(this.buttonSaveFile_AME_Click);
            // 
            // buttonAbout_AME
            // 
            this.buttonAbout_AME.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAbout_AME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAbout_AME.Text = "О программе";
            this.buttonAbout_AME.Location = new System.Drawing.Point(650, 300);
            this.buttonAbout_AME.Size = new System.Drawing.Size(160, 40);
            this.buttonAbout_AME.Click += new System.EventHandler(this.buttonAbout_AME_Click);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(870, 360);
            this.Controls.Add(this.textBoxCondition_AME);
            this.Controls.Add(this.buttonAbout_AME);
            this.Controls.Add(this.buttonSaveFile_AME);
            this.Controls.Add(this.buttonProcess_AME);
            this.Controls.Add(this.buttonOpenFile_AME);
            this.Controls.Add(this.dataGridViewOutput_AME);
            this.Controls.Add(this.dataGridViewInput_AME);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт #6 | Задание 7 | Вариант 26 | Афонин М.Е.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_AME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_AME)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCondition_AME;
        private System.Windows.Forms.DataGridView dataGridViewInput_AME;
        private System.Windows.Forms.DataGridView dataGridViewOutput_AME;
        private System.Windows.Forms.Button buttonOpenFile_AME;
        private System.Windows.Forms.Button buttonProcess_AME;
        private System.Windows.Forms.Button buttonSaveFile_AME;
        private System.Windows.Forms.Button buttonAbout_AME;
    }
}