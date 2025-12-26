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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBoxCondition_AME = new TextBox();
            dataGridViewIn_AME = new DataGridView();
            dataGridViewOut_AME = new DataGridView();
            buttonOpenFile_AME = new Button();
            buttonProcess_AME = new Button();
            buttonSaveFile_AME = new Button();
            buttonAbout_AME = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_AME).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_AME).BeginInit();
            SuspendLayout();
            // 
            // textBoxCondition_AME
            // 
            textBoxCondition_AME.Font = new Font("Microsoft Sans Serif", 10F);
            textBoxCondition_AME.Location = new Point(12, 2);
            textBoxCondition_AME.Multiline = true;
            textBoxCondition_AME.Name = "textBoxCondition_AME";
            textBoxCondition_AME.ReadOnly = true;
            textBoxCondition_AME.ScrollBars = ScrollBars.Vertical;
            textBoxCondition_AME.Size = new Size(820, 102);
            textBoxCondition_AME.TabIndex = 10;
            textBoxCondition_AME.Text = resources.GetString("textBoxCondition_AME.Text");
            // 
            // dataGridViewIn_AME
            // 
            dataGridViewIn_AME.AllowUserToAddRows = false;
            dataGridViewIn_AME.AllowUserToDeleteRows = false;
            dataGridViewIn_AME.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_AME.Location = new Point(12, 110);
            dataGridViewIn_AME.Name = "dataGridViewIn_AME";
            dataGridViewIn_AME.ReadOnly = true;
            dataGridViewIn_AME.RowHeadersVisible = false;
            dataGridViewIn_AME.Size = new Size(380, 200);
            dataGridViewIn_AME.TabIndex = 16;
            dataGridViewIn_AME.CellContentClick += dataGridViewIn_AME_CellContentClick;
            // 
            // dataGridViewOut_AME
            // 
            dataGridViewOut_AME.AllowUserToAddRows = false;
            dataGridViewOut_AME.AllowUserToDeleteRows = false;
            dataGridViewOut_AME.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_AME.Location = new Point(452, 110);
            dataGridViewOut_AME.Name = "dataGridViewOut_AME";
            dataGridViewOut_AME.ReadOnly = true;
            dataGridViewOut_AME.RowHeadersVisible = false;
            dataGridViewOut_AME.Size = new Size(380, 200);
            dataGridViewOut_AME.TabIndex = 15;
            // 
            // buttonOpenFile_AME
            // 
            buttonOpenFile_AME.BackColor = Color.LightSteelBlue;
            buttonOpenFile_AME.Font = new Font("Microsoft Sans Serif", 10F);
            buttonOpenFile_AME.Image = (Image)resources.GetObject("buttonOpenFile_AME.Image");
            buttonOpenFile_AME.Location = new Point(88, 330);
            buttonOpenFile_AME.Name = "buttonOpenFile_AME";
            buttonOpenFile_AME.Size = new Size(160, 40);
            buttonOpenFile_AME.TabIndex = 14;
            buttonOpenFile_AME.UseVisualStyleBackColor = false;
            buttonOpenFile_AME.Click += buttonOpenFile_AME_Click;
            // 
            // buttonProcess_AME
            // 
            buttonProcess_AME.BackColor = Color.LightSteelBlue;
            buttonProcess_AME.Font = new Font("Microsoft Sans Serif", 10F);
            buttonProcess_AME.Image = (Image)resources.GetObject("buttonProcess_AME.Image");
            buttonProcess_AME.Location = new Point(254, 330);
            buttonProcess_AME.Name = "buttonProcess_AME";
            buttonProcess_AME.Size = new Size(160, 40);
            buttonProcess_AME.TabIndex = 13;
            buttonProcess_AME.UseVisualStyleBackColor = false;
            buttonProcess_AME.Click += buttonProcess_AME_Click;
            // 
            // buttonSaveFile_AME
            // 
            buttonSaveFile_AME.BackColor = Color.LightSteelBlue;
            buttonSaveFile_AME.Font = new Font("Microsoft Sans Serif", 10F);
            buttonSaveFile_AME.Image = (Image)resources.GetObject("buttonSaveFile_AME.Image");
            buttonSaveFile_AME.Location = new Point(420, 330);
            buttonSaveFile_AME.Name = "buttonSaveFile_AME";
            buttonSaveFile_AME.Size = new Size(160, 40);
            buttonSaveFile_AME.TabIndex = 12;
            buttonSaveFile_AME.UseVisualStyleBackColor = false;
            buttonSaveFile_AME.Click += buttonSaveFile_AME_Click;
            // 
            // buttonAbout_AME
            // 
            buttonAbout_AME.BackColor = Color.LightSteelBlue;
            buttonAbout_AME.Font = new Font("Microsoft Sans Serif", 10F);
            buttonAbout_AME.Image = (Image)resources.GetObject("buttonAbout_AME.Image");
            buttonAbout_AME.Location = new Point(586, 330);
            buttonAbout_AME.Name = "buttonAbout_AME";
            buttonAbout_AME.Size = new Size(160, 40);
            buttonAbout_AME.TabIndex = 11;
            buttonAbout_AME.UseVisualStyleBackColor = false;
            buttonAbout_AME.Click += buttonAbout_AME_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(850, 400);
            Controls.Add(textBoxCondition_AME);
            Controls.Add(buttonAbout_AME);
            Controls.Add(buttonSaveFile_AME);
            Controls.Add(buttonProcess_AME);
            Controls.Add(buttonOpenFile_AME);
            Controls.Add(dataGridViewOut_AME);
            Controls.Add(dataGridViewIn_AME);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Task 7 | Вариант 26 | Афонин М.Е.";
            Resize += FormMain_Resize;
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_AME).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_AME).EndInit();
            ResumeLayout(false);
            PerformLayout();
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