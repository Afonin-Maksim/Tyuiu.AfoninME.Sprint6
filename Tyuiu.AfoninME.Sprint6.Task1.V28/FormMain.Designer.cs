namespace Tyuiu.AfoninME.Sprint6.Task1.V28
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
            this.textBoxResult_AfoninME = new System.Windows.Forms.TextBox();
            this.buttonDoCalculate_AfoninME = new System.Windows.Forms.Button();
            this.buttonHelp_AfoninME = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCondition_AfoninME
            // 
            this.labelCondition_AfoninME.AutoSize = true;
            this.labelCondition_AfoninME.Location = new System.Drawing.Point(20, 20);
            this.labelCondition_AfoninME.Name = "labelCondition_AfoninME";
            this.labelCondition_AfoninME.Size = new System.Drawing.Size(400, 13);
            this.labelCondition_AfoninME.TabIndex = 0;
            this.labelCondition_AfoninME.Text = "Табулирование функции F(x) = cos(x) + (4x / 2) - sin(x) * 3x для x ∈ [-5; 5]";
            // 
            // textBoxResult_AfoninME
            // 
            this.textBoxResult_AfoninME.Location = new System.Drawing.Point(23, 50);
            this.textBoxResult_AfoninME.Multiline = true;
            this.textBoxResult_AfoninME.Name = "textBoxResult_AfoninME";
            this.textBoxResult_AfoninME.ReadOnly = true;
            this.textBoxResult_AfoninME.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_AfoninME.Size = new System.Drawing.Size(260, 220);
            this.textBoxResult_AfoninME.TabIndex = 1;
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
            this.ClientSize = new System.Drawing.Size(460, 300);
            this.Controls.Add(this.buttonHelp_AfoninME);
            this.Controls.Add(this.buttonDoCalculate_AfoninME);
            this.Controls.Add(this.textBoxResult_AfoninME);
            this.Controls.Add(this.labelCondition_AfoninME);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Task 1 | Вариант 28 | Афонин М.Е.";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelCondition_AfoninME;
        private System.Windows.Forms.TextBox textBoxResult_AfoninME;
        private System.Windows.Forms.Button buttonDoCalculate_AfoninME;
        private System.Windows.Forms.Button buttonHelp_AfoninME;
    }
}