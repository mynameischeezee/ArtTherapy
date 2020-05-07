namespace ArtTherapy
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogoIMG = new System.Windows.Forms.PictureBox();
            this.CloseIMG = new System.Windows.Forms.PictureBox();
            this.questionPart21 = new ArtTherapy.Presentation.UsrCtrl.QuestionPart2();
            this.questionPart11 = new ArtTherapy.Presentation.UsrCtrl.QuestionPart1();
            this.res = new ArtTherapy.Presentation.UsrCtrl.Resultt();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoIMG
            // 
            this.LogoIMG.BackColor = System.Drawing.Color.Transparent;
            this.LogoIMG.Image = global::ArtTherapy.Properties.Resources.Logo;
            this.LogoIMG.Location = new System.Drawing.Point(12, 12);
            this.LogoIMG.Name = "LogoIMG";
            this.LogoIMG.Size = new System.Drawing.Size(211, 94);
            this.LogoIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LogoIMG.TabIndex = 0;
            this.LogoIMG.TabStop = false;
            // 
            // CloseIMG
            // 
            this.CloseIMG.BackColor = System.Drawing.Color.Transparent;
            this.CloseIMG.Image = global::ArtTherapy.Properties.Resources.Close;
            this.CloseIMG.Location = new System.Drawing.Point(1246, 12);
            this.CloseIMG.Name = "CloseIMG";
            this.CloseIMG.Size = new System.Drawing.Size(22, 25);
            this.CloseIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseIMG.TabIndex = 1;
            this.CloseIMG.TabStop = false;
            this.CloseIMG.Click += new System.EventHandler(this.CloseIMG_Click);
            // 
            // questionPart21
            // 
            this.questionPart21.BackColor = System.Drawing.Color.White;
            this.questionPart21.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.questionPart21.Location = new System.Drawing.Point(120, 90);
            this.questionPart21.Name = "questionPart21";
            this.questionPart21.Size = new System.Drawing.Size(1152, 618);
            this.questionPart21.TabIndex = 3;
            // 
            // questionPart11
            // 
            this.questionPart11.BackColor = System.Drawing.Color.White;
            this.questionPart11.Location = new System.Drawing.Point(120, 90);
            this.questionPart11.Name = "questionPart11";
            this.questionPart11.Size = new System.Drawing.Size(1152, 618);
            this.questionPart11.TabIndex = 2;
            // 
            // res
            // 
            this.res.BackColor = System.Drawing.Color.White;
            this.res.Location = new System.Drawing.Point(0, 0);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(1280, 720);
            this.res.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArtTherapy.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.res);
            this.Controls.Add(this.questionPart21);
            this.Controls.Add(this.questionPart11);
            this.Controls.Add(this.CloseIMG);
            this.Controls.Add(this.LogoIMG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseIMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoIMG;
        private System.Windows.Forms.PictureBox CloseIMG;
        private Presentation.UsrCtrl.QuestionPart1 questionPart11;
        private Presentation.UsrCtrl.QuestionPart2 questionPart21;
        private Presentation.UsrCtrl.Resultt res;
    }
}

