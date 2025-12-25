namespace Tyuiu.AfoninME.Sprint6.Task7.V26
{
    partial class FormAbout
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBoxLogo_AME = new System.Windows.Forms.PictureBox();
            this.labelInfo_AME = new System.Windows.Forms.Label();
            this.buttonOk_AME = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo_AME)).BeginInit();
            this.SuspendLayout();
            
            this.pictureBoxLogo_AME.Image = System.Drawing.Image.FromFile("C:\\DataSprint6\\about.jpg");
            this.pictureBoxLogo_AME.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo_AME.Name = "pictureBoxLogo_AME";
            this.pictureBoxLogo_AME.Size = new System.Drawing.Size(260, 220);
            this.pictureBoxLogo_AME.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo_AME.TabStop = false;
           
            this.labelInfo_AME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelInfo_AME.Location = new System.Drawing.Point(280, 20);
            this.labelInfo_AME.Size = new System.Drawing.Size(370, 180);
            this.labelInfo_AME.Text =
                "Разработчик: Афонин Максим Евгеньевич\n" +
                "Группа: ИСТНб-25-1\n\n" +
                "Тюменский индустриальный университет, 2025\n" +
                "Высшая школа цифровых технологий, 2025\n\n" +
                "Внутреннее имя: Tyuiu.AfoninME.Sprint6.Task7.V26";
             
            this.buttonOk_AME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonOk_AME.Location = new System.Drawing.Point(550, 210);
            this.buttonOk_AME.Size = new System.Drawing.Size(100, 30);
            this.buttonOk_AME.Text = "Ок";
            this.buttonOk_AME.Click += new System.EventHandler(this.buttonOk_AME_Click);
             
            this.ClientSize = new System.Drawing.Size(660, 260);
            this.Controls.Add(this.buttonOk_AME);
            this.Controls.Add(this.labelInfo_AME);
            this.Controls.Add(this.pictureBoxLogo_AME);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo_AME)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBoxLogo_AME;
        private System.Windows.Forms.Label labelInfo_AME;
        private System.Windows.Forms.Button buttonOk_AME;
    }
}