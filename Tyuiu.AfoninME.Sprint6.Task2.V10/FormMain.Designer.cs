namespace Tyuiu.AfoninME.Sprint6.Task2.V10
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
            this.labelCondition_AfoninME = new System.Windows.Forms.Label();
            this.dataGridViewValues_AfoninME = new System.Windows.Forms.DataGridView();
            this.ColumnX_AfoninME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnY_AfoninME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDoCalculate_AfoninME = new System.Windows.Forms.Button();
            this.buttonHelp_AfoninME = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues_AfoninME)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCondition_AfoninME
            // 
            this.labelCondition_AfoninME.AutoSize = true;
            this.labelCondition_AfoninME.Location = new System.Drawing.Point(20, 20);
            this.labelCondition_AfoninME.Name = "labelCondition_AfoninME";
            this.labelCondition_AfoninME.Size = new System.Drawing.Size(410, 13);
            this.labelCondition_AfoninME.TabIndex = 0;
            this.labelCondition_AfoninME.Text = "F(x) = 2x - 4 + (2x - 1)/(sin(x) + 1), табулирование x ∈ [-5; 5] с шагом 1";
            // 
            // dataGridViewValues_AfoninME
            // 
            this.dataGridViewValues_AfoninME.AllowUserToAddRows = false;
            this.dataGridViewValues_AfoninME.AllowUserToDeleteRows = false;
            this.dataGridViewValues_AfoninME.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValues_AfoninME.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX_AfoninME,
            this.ColumnY_AfoninME});
            this.dataGridViewValues_AfoninME.Location = new System.Drawing.Point(23, 50);
            this.dataGridViewValues_AfoninME.Name = "dataGridViewValues_AfoninME";
            this.dataGridViewValues_AfoninME.ReadOnly = true;
            this.dataGridViewValues_AfoninME.Size = new System.Drawing.Size(260, 250);
            this.dataGridViewValues_AfoninME.TabIndex = 1;
            // 
            // ColumnX_AfoninME
            // 
            this.ColumnX_AfoninME.HeaderText = "X";
            this.ColumnX_AfoninME.Name = "ColumnX_AfoninME";
            this.ColumnX_AfoninME.ReadOnly = true;
            this.ColumnX_AfoninME.Width = 80;
            // 
            // ColumnY_AfoninME
            // 
            this.ColumnY_AfoninME.HeaderText = "F(X)";
            this.ColumnY_AfoninME.Name = "ColumnY_AfoninME";
            this.ColumnY_AfoninME.ReadOnly = true;
            this.ColumnY_AfoninME.Width = 120;
            // 
            // buttonDoCalculate_AfoninME
            // 
            this.buttonDoCalculate_AfoninME.Location = new System.Drawing.Point(300, 50);
            this.buttonDoCalculate_AfoninME.Name = "buttonDoCalculate_AfoninME";
            this.buttonDoCalculate_AfoninME.Size = new System.Drawing.Size(100, 23);
            this.buttonDoCalculate_AfoninME.TabIndex = 2;
            this.buttonDoCalculate_AfoninME.Text = "Выполнить";
            this.buttonDoCalculate_AfoninME.UseVisualStyleBackColor = true;
            this.buttonDoCalculate_AfoninME.Click += new System.EventHandler(this.buttonDoCalculate_AfoninME_Click);
            // 
            // buttonHelp_AfoninME
            // 
            this.buttonHelp_AfoninME.Location = new System.Drawing.Point(410, 50);
            this.buttonHelp_AfoninME.Name = "buttonHelp_AfoninME";
            this.buttonHelp_AfoninME.Size = new System.Drawing.Size(30, 23);
            this.buttonHelp_AfoninME.TabIndex = 3;
            this.buttonHelp_AfoninME.Text = "?";
            this.buttonHelp_AfoninME.UseVisualStyleBackColor = true;
            this.buttonHelp_AfoninME.Click += new System.EventHandler(this.buttonHelp_AfoninME_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 330);
            this.Controls.Add(this.buttonHelp_AfoninME);
            this.Controls.Add(this.buttonDoCalculate_AfoninME);
            this.Controls.Add(this.dataGridViewValues_AfoninME);
            this.Controls.Add(this.labelCondition_AfoninME);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Task 2 | Вариант 10 | Афонин М.Е.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues_AfoninME)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelCondition_AfoninME;
        private System.Windows.Forms.DataGridView dataGridViewValues_AfoninME;
        private System.Windows.Forms.Button buttonDoCalculate_AfoninME;
        private System.Windows.Forms.Button buttonHelp_AfoninME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX_AfoninME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnY_AfoninME;
    }
}