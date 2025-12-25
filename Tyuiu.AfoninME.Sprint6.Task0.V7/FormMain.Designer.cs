namespace Tyuiu.AfoninME.Sprint6.Task0.V7
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
            this.labelResult_AfoninME = new System.Windows.Forms.Label();
            this.buttonCalculate_AfoninME = new System.Windows.Forms.Button();
            this.buttonHelp_AfoninME = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCondition_AfoninME
            // 
            this.labelCondition_AfoninME.AutoSize = true;
            this.labelCondition_AfoninME.Location = new System.Drawing.Point(20, 20);
            this.labelCondition_AfoninME.Name = "labelCondition_AfoninME";
            this.labelCondition_AfoninME.Size = new System.Drawing.Size(360, 13);
            this.labelCondition_AfoninME.TabIndex = 0;
            this.labelCondition_AfoninME.Text = "Вычислить значение выражения y = x³ / (2 * (x + 5)²) при x = 3.";
            // 
            // labelResult_foninME
            // 
            this.labelResult_AfoninME.AutoSize = true;
            this.labelResult_AfoninME.Location = new System.Drawing.Point(20, 60);
            this.labelResult_AfoninME.Name = "labelResult_AfoninME";
            this.labelResult_AfoninME.Size = new System.Drawing.Size(55, 13);
            this.labelResult_AfoninME.TabIndex = 1;
            this.labelResult_AfoninME.Text = "Результат:";
            // 
            // textBoxResult_AfoninME
            // 
            this.textBoxResult_AfoninME.Location = new System.Drawing.Point(100, 57);
            this.textBoxResult_AfoninME.Name = "textBoxResult_AfoninME";
            this.textBoxResult_AfoninME.ReadOnly = true;
            this.textBoxResult_AfoninME.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_AfoninME.TabIndex = 2;
            // 
            // buttonCalculate_AfoninME
            // 
            this.buttonCalculate_AfoninME.Location = new System.Drawing.Point(220, 55);
            this.buttonCalculate_AfoninME.Name = "buttonCalculate_AfoninME";
            this.buttonCalculate_AfoninME.Size = new System.Drawing.Size(100, 23);
            this.buttonCalculate_AfoninME.TabIndex = 3;
            this.buttonCalculate_AfoninME.Text = "Выполнить";
            this.buttonCalculate_AfoninME.UseVisualStyleBackColor = true;
            this.buttonCalculate_AfoninME.Click += new System.EventHandler(this.buttonCalculate_AfoninME_Click);
            // 
            // buttonHelp_AfoninME
            // 
            this.buttonHelp_AfoninME.Location = new System.Drawing.Point(330, 55);
            this.buttonHelp_AfoninME.Name = "buttonHelp_AfoninME";
            this.buttonHelp_AfoninME.Size = new System.Drawing.Size(30, 23);
            this.buttonHelp_AfoninME.TabIndex = 4;
            this.buttonHelp_AfoninME.Text = "?";
            this.buttonHelp_AfoninME.UseVisualStyleBackColor = true;
            this.buttonHelp_AfoninME.Click += new System.EventHandler(this.buttonHelp_AfoninME_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 120);
            this.Controls.Add(this.buttonHelp_AfoninME);
            this.Controls.Add(this.buttonCalculate_AfoninME);
            this.Controls.Add(this.textBoxResult_AfoninME);
            this.Controls.Add(this.labelResult_AfoninME);
            this.Controls.Add(this.labelCondition_AfoninME);
            this.Name = "FormMain";
            this.Text = "Спринт #6 | Задание #0 | Вариант #7 | Афонин М.Е.";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelCondition_AfoninME;
        private System.Windows.Forms.Label labelResult_AfoninME;
        private System.Windows.Forms.TextBox textBoxResult_AfoninME;
        private System.Windows.Forms.Button buttonCalculate_AfoninME;
        private System.Windows.Forms.Button buttonHelp_AfoninME;
    }
}