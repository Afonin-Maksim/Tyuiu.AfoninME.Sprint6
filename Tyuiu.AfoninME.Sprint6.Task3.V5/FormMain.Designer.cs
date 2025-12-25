namespace Tyuiu.AfoninME.Sprint6.Task3.V5
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
            this.dataGridViewInput_AfoninME = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutput_AfoninME = new System.Windows.Forms.DataGridView();
            this.buttonDoSort_AfoninME = new System.Windows.Forms.Button();
            this.buttonHelp_AfoninME = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_AfoninME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_AfoninME)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCondition_AfoninME
            // 
            this.labelCondition_AfoninME.AutoSize = true;
            this.labelCondition_AfoninME.Location = new System.Drawing.Point(20, 20);
            this.labelCondition_AfoninME.Name = "labelCondition_AfoninME";
            this.labelCondition_AfoninME.Size = new System.Drawing.Size(277, 13);
            this.labelCondition_AfoninME.TabIndex = 0;
            this.labelCondition_AfoninME.Text = "Сортировка по возрастанию элементов третьего столбца";
            // 
            // dataGridViewInput_AfoninME
            // 
            this.dataGridViewInput_AfoninME.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_AfoninME.Location = new System.Drawing.Point(23, 50);
            this.dataGridViewInput_AfoninME.Name = "dataGridViewInput_AfoninME";
            this.dataGridViewInput_AfoninME.ReadOnly = true;
            this.dataGridViewInput_AfoninME.Size = new System.Drawing.Size(260, 200);
            this.dataGridViewInput_AfoninME.TabIndex = 1;
            // 
            // dataGridViewOutput_AfoninME
            // 
            this.dataGridViewOutput_AfoninME.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_AfoninME.Location = new System.Drawing.Point(300, 50);
            this.dataGridViewOutput_AfoninME.Name = "dataGridViewOutput_AfoninME";
            this.dataGridViewOutput_AfoninME.ReadOnly = true;
            this.dataGridViewOutput_AfoninME.Size = new System.Drawing.Size(260, 200);
            this.dataGridViewOutput_AfoninME.TabIndex = 2;
            // 
            // buttonDoSort_AfoninME
            // 
            this.buttonDoSort_AfoninME.Location = new System.Drawing.Point(580, 50);
            this.buttonDoSort_AfoninME.Name = "buttonDoSort_AfoninME";
            this.buttonDoSort_AfoninME.Size = new System.Drawing.Size(100, 23);
            this.buttonDoSort_AfoninME.TabIndex = 3;
            this.buttonDoSort_AfoninME.Text = "Сортировать";
            this.buttonDoSort_AfoninME.UseVisualStyleBackColor = true;
            this.buttonDoSort_AfoninME.Click += new System.EventHandler(this.buttonDoSort_AfoninME_Click);
            // 
            // buttonHelp_AfoninME
            // 
            this.buttonHelp_AfoninME.Location = new System.Drawing.Point(700, 50);
            this.buttonHelp_AfoninME.Name = "buttonHelp_AfoninME";
            this.buttonHelp_AfoninME.Size = new System.Drawing.Size(30, 23);
            this.buttonHelp_AfoninME.TabIndex = 4;
            this.buttonHelp_AfoninME.Text = "?";
            this.buttonHelp_AfoninME.UseVisualStyleBackColor = true;
            this.buttonHelp_AfoninME.Click += new System.EventHandler(this.buttonHelp_AfoninME_Click);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(760, 280);
            this.Controls.Add(this.buttonHelp_AfoninME);
            this.Controls.Add(this.buttonDoSort_AfoninME);
            this.Controls.Add(this.dataGridViewOutput_AfoninME);
            this.Controls.Add(this.dataGridViewInput_AfoninME);
            this.Controls.Add(this.labelCondition_AfoninME);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Task 3 | Вариант 5 | Афонин М.Е.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_AfoninME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_AfoninME)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelCondition_AfoninME;
        private System.Windows.Forms.DataGridView dataGridViewInput_AfoninME;
        private System.Windows.Forms.DataGridView dataGridViewOutput_AfoninME;
        private System.Windows.Forms.Button buttonDoSort_AfoninME;
        private System.Windows.Forms.Button buttonHelp_AfoninME;
    }
}