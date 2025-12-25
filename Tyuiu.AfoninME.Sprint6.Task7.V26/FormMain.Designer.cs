namespace Tyuiu.AfoninME.Sprint6.Task7.V26
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.textBoxCondition_AME = new System.Windows.Forms.TextBox();
            this.dataGridViewIn_AME = new System.Windows.Forms.DataGridView();
            this.dataGridViewOut_AME = new System.Windows.Forms.DataGridView();
            this.buttonOpenFile_AME = new System.Windows.Forms.Button();
            this.buttonProcess_AME = new System.Windows.Forms.Button();
            this.buttonSaveFile_AME = new System.Windows.Forms.Button();
            this.buttonAbout_AME = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_AME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_AME)).BeginInit();
            this.SuspendLayout();
            
            this.textBoxCondition_AME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCondition_AME.Location = new System.Drawing.Point(12, 12);
            this.textBoxCondition_AME.Multiline = true;
            this.textBoxCondition_AME.Name = "textBoxCondition_AME";
            this.textBoxCondition_AME.ReadOnly = true;
            this.textBoxCondition_AME.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCondition_AME.Size = new System.Drawing.Size(820, 80);
            this.textBoxCondition_AME.TabIndex = 10;
            
            this.dataGridViewIn_AME.AllowUserToAddRows = false;
            this.dataGridViewIn_AME.AllowUserToDeleteRows = false;
            this.dataGridViewIn_AME.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_AME.Location = new System.Drawing.Point(12, 110);
            this.dataGridViewIn_AME.Name = "dataGridViewIn_AME";
            this.dataGridViewIn_AME.ReadOnly = true;
            this.dataGridViewIn_AME.Size = new System.Drawing.Size(380, 200);
            
            this.dataGridViewOut_AME.AllowUserToAddRows = false;
            this.dataGridViewOut_AME.AllowUserToDeleteRows = false;
            this.dataGridViewOut_AME.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_AME.Location = new System.Drawing.Point(412, 110);
            this.dataGridViewOut_AME.Name = "dataGridViewOut_AME";
            this.dataGridViewOut_AME.ReadOnly = true;
            this.dataGridViewOut_AME.Size = new System.Drawing.Size(380, 200);
            
            this.buttonOpenFile_AME.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonOpenFile_AME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonOpenFile_AME.Location = new System.Drawing.Point(12, 330);
            this.buttonOpenFile_AME.Name = "buttonOpenFile_AME";
            this.buttonOpenFile_AME.Size = new System.Drawing.Size(160, 40);
            this.buttonOpenFile_AME.Text = "Открыть файл";
            this.buttonOpenFile_AME.UseVisualStyleBackColor = false;
            this.buttonOpenFile_AME.Click += new System.EventHandler(this.buttonOpenFile_AME_Click);
            
            this.buttonProcess_AME.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonProcess_AME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonProcess_AME.Location = new System.Drawing.Point(200, 330);
            this.buttonProcess_AME.Name = "buttonProcess_AME";
            this.buttonProcess_AME.Size = new System.Drawing.Size(160, 40);
            this.buttonProcess_AME.Text = "Обработать";
            this.buttonProcess_AME.UseVisualStyleBackColor = false;
            this.buttonProcess_AME.Click += new System.EventHandler(this.buttonProcess_AME_Click);
            
            this.buttonSaveFile_AME.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSaveFile_AME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSaveFile_AME.Location = new System.Drawing.Point(390, 330);
            this.buttonSaveFile_AME.Name = "buttonSaveFile_AME";
            this.buttonSaveFile_AME.Size = new System.Drawing.Size(160, 40);
            this.buttonSaveFile_AME.Text = "Сохранить";
            this.buttonSaveFile_AME.UseVisualStyleBackColor = false;
            this.buttonSaveFile_AME.Click += new System.EventHandler(this.buttonSaveFile_AME_Click);
            
            this.buttonAbout_AME.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAbout_AME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAbout_AME.Location = new System.Drawing.Point(580, 330);
            this.buttonAbout_AME.Name = "buttonAbout_AME";
            this.buttonAbout_AME.Size = new System.Drawing.Size(160, 40);
            this.buttonAbout_AME.Text = "О программе";
            this.buttonAbout_AME.UseVisualStyleBackColor = false;
            this.buttonAbout_AME.Click += new System.EventHandler(this.buttonAbout_AME_Click);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(850, 400);
            this.Controls.Add(this.textBoxCondition_AME);
            this.Controls.Add(this.buttonAbout_AME);
            this.Controls.Add(this.buttonSaveFile_AME);
            this.Controls.Add(this.buttonProcess_AME);
            this.Controls.Add(this.buttonOpenFile_AME);
            this.Controls.Add(this.dataGridViewOut_AME);
            this.Controls.Add(this.dataGridViewIn_AME);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт #6 | Task 7 | Вариант 26 | Афонин М.Е.";
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_AME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_AME)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.TextBox textBoxCondition_AME;
        private System.Windows.Forms.DataGridView dataGridViewIn_AME;
        private System.Windows.Forms.DataGridView dataGridViewOut_AME;
        private System.Windows.Forms.Button buttonOpenFile_AME;
        private System.Windows.Forms.Button buttonProcess_AME;
        private System.Windows.Forms.Button buttonSaveFile_AME;
        private System.Windows.Forms.Button buttonAbout_AME;
    }
}