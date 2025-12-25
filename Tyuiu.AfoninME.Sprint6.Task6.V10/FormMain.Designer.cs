namespace Tyuiu.AfoninME.Sprint6.Task6.V10
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

        private void InitializeComponent()
        {
            this.labelTitle_AfoninME = new System.Windows.Forms.Label();
            this.textBoxInput_AfoninME = new System.Windows.Forms.TextBox();
            this.textBoxOutput_AfoninME = new System.Windows.Forms.TextBox();
            this.buttonOpenFile_AfoninME = new System.Windows.Forms.Button();
            this.buttonProcess_AfoninME = new System.Windows.Forms.Button();
            this.buttonHelp_AfoninME = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle_AfoninME
            // 
            this.labelTitle_AfoninME.AutoSize = true;
            this.labelTitle_AfoninME.Location = new System.Drawing.Point(20, 20);
            this.labelTitle_AfoninME.Name = "labelTitle_AfoninME";
            this.labelTitle_AfoninME.Size = new System.Drawing.Size(450, 13);
            this.labelTitle_AfoninME.TabIndex = 0;
            this.labelTitle_AfoninME.Text = "Вариант 10. Слова, содержащие 'w' / 'W', из файла InPutFileTask6V10.txt (через OpenFileDialog)";
            // 
            // textBoxInput_AfoninME
            // 
            this.textBoxInput_AfoninME.Location = new System.Drawing.Point(23, 50);
            this.textBoxInput_AfoninME.Multiline = true;
            this.textBoxInput_AfoninME.ReadOnly = true;
            this.textBoxInput_AfoninME.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput_AfoninME.Size = new System.Drawing.Size(420, 100);
            this.textBoxInput_AfoninME.TabIndex = 1;
            // 
            // textBoxOutput_AfoninME
            // 
            this.textBoxOutput_AfoninME.Location = new System.Drawing.Point(23, 180);
            this.textBoxOutput_AfoninME.Multiline = true;
            this.textBoxOutput_AfoninME.ReadOnly = true;
            this.textBoxOutput_AfoninME.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_AfoninME.Size = new System.Drawing.Size(420, 80);
            this.textBoxOutput_AfoninME.TabIndex = 2;
            // 
            // buttonOpenFile_AfoninME
            // 
            this.buttonOpenFile_AfoninME.Location = new System.Drawing.Point(460, 50);
            this.buttonOpenFile_AfoninME.Name = "buttonOpenFile_AfoninME";
            this.buttonOpenFile_AfoninME.Size = new System.Drawing.Size(110, 25);
            this.buttonOpenFile_AfoninME.TabIndex = 3;
            this.buttonOpenFile_AfoninME.Text = "Открыть файл";
            this.buttonOpenFile_AfoninME.UseVisualStyleBackColor = true;
            this.buttonOpenFile_AfoninME.Click += new System.EventHandler(this.buttonOpenFile_AfoninME_Click);
            // 
            // buttonProcess_AfoninME
            // 
            this.buttonProcess_AfoninME.Location = new System.Drawing.Point(460, 90);
            this.buttonProcess_AfoninME.Name = "buttonProcess_AfoninME";
            this.buttonProcess_AfoninME.Size = new System.Drawing.Size(110, 25);
            this.buttonProcess_AfoninME.TabIndex = 4;
            this.buttonProcess_AfoninME.Text = "Выполнить";
            this.buttonProcess_AfoninME.UseVisualStyleBackColor = true;
            this.buttonProcess_AfoninME.Click += new System.EventHandler(this.buttonProcess_AfoninME_Click);
            // 
            // buttonHelp_AfoninME
            // 
            this.buttonHelp_AfoninME.Location = new System.Drawing.Point(520, 235);
            this.buttonHelp_AfoninME.Name = "buttonHelp_AfoninME";
            this.buttonHelp_AfoninME.Size = new System.Drawing.Size(30, 25);
            this.buttonHelp_AfoninME.TabIndex = 5;
            this.buttonHelp_AfoninME.Text = "?";
            this.buttonHelp_AfoninME.UseVisualStyleBackColor = true;
            this.buttonHelp_AfoninME.Click += new System.EventHandler(this.buttonHelp_AfoninME_Click);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(600, 290);
            this.Controls.Add(this.buttonHelp_AfoninME);
            this.Controls.Add(this.buttonProcess_AfoninME);
            this.Controls.Add(this.buttonOpenFile_AfoninME);
            this.Controls.Add(this.textBoxOutput_AfoninME);
            this.Controls.Add(this.textBoxInput_AfoninME);
            this.Controls.Add(this.labelTitle_AfoninME);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Task 6 | Вариант 10 | Афонин М.Е.";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle_AfoninME;
        private System.Windows.Forms.TextBox textBoxInput_AfoninME;
        private System.Windows.Forms.TextBox textBoxOutput_AfoninME;
        private System.Windows.Forms.Button buttonOpenFile_AfoninME;
        private System.Windows.Forms.Button buttonProcess_AfoninME;
        private System.Windows.Forms.Button buttonHelp_AfoninME;
    }
}