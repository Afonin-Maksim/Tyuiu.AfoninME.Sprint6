namespace Tyuiu.AfoninME.Sprint6.Task4.V17
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
            this.labelCondition_AfoninME = new System.Windows.Forms.Label();
            this.dataGridResult_AfoninME = new System.Windows.Forms.DataGridView();
            this.ColumnX_AfoninME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnY_AfoninME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCalculate_AfoninME = new System.Windows.Forms.Button();
            this.buttonSave_AfoninME = new System.Windows.Forms.Button();
            this.buttonHelp_AfoninME = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult_AfoninME)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCondition_AfoninME
            // 
            this.labelCondition_AfoninME.AutoSize = true;
            this.labelCondition_AfoninME.Location = new System.Drawing.Point(20, 20);
            this.labelCondition_AfoninME.Name = "labelCondition_AfoninME";
            this.labelCondition_AfoninME.Size = new System.Drawing.Size(360, 13);
            this.labelCondition_AfoninME.TabIndex = 0;
            this.labelCondition_AfoninME.Text = "F(x) = sin(x)/(x+1.7) - cos(x)*4x - 6, табулирование x ∈ [-5;5]";
            // 
            // dataGridResult_AfoninME
            // 
            this.dataGridResult_AfoninME.AllowUserToAddRows = false;
            this.dataGridResult_AfoninME.AllowUserToDeleteRows = false;
            this.dataGridResult_AfoninME.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResult_AfoninME.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[] {
                    this.ColumnX_AfoninME, this.ColumnY_AfoninME});
            this.dataGridResult_AfoninME.Location = new System.Drawing.Point(23, 50);
            this.dataGridResult_AfoninME.Name = "dataGridResult_AfoninME";
            this.dataGridResult_AfoninME.ReadOnly = true;
            this.dataGridResult_AfoninME.Size = new System.Drawing.Size(250, 220);
            this.dataGridResult_AfoninME.TabIndex = 1;
            // 
            // ColumnX_AfoninME
            // 
            this.ColumnX_AfoninME.HeaderText = "x";
            this.ColumnX_AfoninME.Name = "ColumnX_AfoninME";
            this.ColumnX_AfoninME.ReadOnly = true;
            this.ColumnX_AfoninME.Width = 80;
            // 
            // ColumnY_AfoninME
            // 
            this.ColumnY_AfoninME.HeaderText = "F(x)";
            this.ColumnY_AfoninME.Name = "ColumnY_AfoninME";
            this.ColumnY_AfoninME.ReadOnly = true;
            this.ColumnY_AfoninME.Width = 110;
            // 
            // buttonCalculate_AfoninME
            // 
            this.buttonCalculate_AfoninME.Location = new System.Drawing.Point(300, 50);
            this.buttonCalculate_AfoninME.Name = "buttonCalculate_AfoninME";
            this.buttonCalculate_AfoninME.Size = new System.Drawing.Size(100, 25);
            this.buttonCalculate_AfoninME.TabIndex = 2;
            this.buttonCalculate_AfoninME.Text = "Выполнить";
            this.buttonCalculate_AfoninME.UseVisualStyleBackColor = true;
            this.buttonCalculate_AfoninME.Click +=
                new System.EventHandler(this.buttonCalculate_AfoninME_Click);
            // 
            // buttonSave_AfoninME
            // 
            this.buttonSave_AfoninME.Location = new System.Drawing.Point(300, 90);
            this.buttonSave_AfoninME.Name = "buttonSave_AfoninME";
            this.buttonSave_AfoninME.Size = new System.Drawing.Size(100, 25);
            this.buttonSave_AfoninME.TabIndex = 3;
            this.buttonSave_AfoninME.Text = "Сохранить";
            this.buttonSave_AfoninME.UseVisualStyleBackColor = true;
            this.buttonSave_AfoninME.Click +=
                new System.EventHandler(this.buttonSave_AfoninME_Click);
            // 
            // buttonHelp_AfoninME
            // 
            this.buttonHelp_AfoninME.Location = new System.Drawing.Point(325, 245);
            this.buttonHelp_AfoninME.Name = "buttonHelp_AfoninME";
            this.buttonHelp_AfoninME.Size = new System.Drawing.Size(30, 25);
            this.buttonHelp_AfoninME.TabIndex = 4;
            this.buttonHelp_AfoninME.Text = "?";
            this.buttonHelp_AfoninME.UseVisualStyleBackColor = true;
            this.buttonHelp_AfoninME.Click +=
                new System.EventHandler(this.buttonHelp_AfoninME_Click);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(430, 300);
            this.Controls.Add(this.buttonHelp_AfoninME);
            this.Controls.Add(this.buttonSave_AfoninME);
            this.Controls.Add(this.buttonCalculate_AfoninME);
            this.Controls.Add(this.dataGridResult_AfoninME);
            this.Controls.Add(this.labelCondition_AfoninME);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Task 4 | Вариант 17 | Афонин М.Е.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult_AfoninME)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelCondition_AfoninME;
        private System.Windows.Forms.DataGridView dataGridResult_AfoninME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX_AfoninME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnY_AfoninME;
        private System.Windows.Forms.Button buttonCalculate_AfoninME;
        private System.Windows.Forms.Button buttonSave_AfoninME;
        private System.Windows.Forms.Button buttonHelp_AfoninME;
    }
}