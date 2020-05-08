namespace ArtTherapy.Presentation.UsrCtrl
{
    partial class Resultt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CloseIMG = new System.Windows.Forms.PictureBox();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.ResultIMG = new System.Windows.Forms.PictureBox();
            this.Result2Text = new System.Windows.Forms.TextBox();
            this.lbl_Temperament = new System.Windows.Forms.Label();
            this.lbl_Mood = new System.Windows.Forms.Label();
            this.Temperament = new System.Windows.Forms.Label();
            this.Mood = new System.Windows.Forms.Label();
            this.OpenInBrowser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CloseIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseIMG
            // 
            this.CloseIMG.BackColor = System.Drawing.Color.Transparent;
            this.CloseIMG.Image = global::ArtTherapy.Properties.Resources.Close;
            this.CloseIMG.Location = new System.Drawing.Point(1246, 12);
            this.CloseIMG.Name = "CloseIMG";
            this.CloseIMG.Size = new System.Drawing.Size(22, 25);
            this.CloseIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseIMG.TabIndex = 2;
            this.CloseIMG.TabStop = false;
            this.CloseIMG.Click += new System.EventHandler(this.CloseIMG_Click);
            // 
            // ResultText
            // 
            this.ResultText.BackColor = System.Drawing.Color.White;
            this.ResultText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultText.Enabled = false;
            this.ResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ResultText.Location = new System.Drawing.Point(182, 130);
            this.ResultText.Multiline = true;
            this.ResultText.Name = "ResultText";
            this.ResultText.ReadOnly = true;
            this.ResultText.Size = new System.Drawing.Size(864, 185);
            this.ResultText.TabIndex = 16;
            this.ResultText.Text = "Hello";
            // 
            // ResultIMG
            // 
            this.ResultIMG.Location = new System.Drawing.Point(182, 321);
            this.ResultIMG.Name = "ResultIMG";
            this.ResultIMG.Size = new System.Drawing.Size(300, 300);
            this.ResultIMG.TabIndex = 17;
            this.ResultIMG.TabStop = false;
            // 
            // Result2Text
            // 
            this.Result2Text.BackColor = System.Drawing.Color.White;
            this.Result2Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Result2Text.Enabled = false;
            this.Result2Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result2Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Result2Text.Location = new System.Drawing.Point(488, 321);
            this.Result2Text.Multiline = true;
            this.Result2Text.Name = "Result2Text";
            this.Result2Text.ReadOnly = true;
            this.Result2Text.Size = new System.Drawing.Size(558, 300);
            this.Result2Text.TabIndex = 18;
            this.Result2Text.Text = "Hello";
            // 
            // lbl_Temperament
            // 
            this.lbl_Temperament.AutoSize = true;
            this.lbl_Temperament.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.lbl_Temperament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lbl_Temperament.Location = new System.Drawing.Point(176, 27);
            this.lbl_Temperament.Name = "lbl_Temperament";
            this.lbl_Temperament.Size = new System.Drawing.Size(655, 33);
            this.lbl_Temperament.TabIndex = 19;
            this.lbl_Temperament.Text = "За результатми тестування ваш темперамент: ";
            // 
            // lbl_Mood
            // 
            this.lbl_Mood.AutoSize = true;
            this.lbl_Mood.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.lbl_Mood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lbl_Mood.Location = new System.Drawing.Point(176, 60);
            this.lbl_Mood.Name = "lbl_Mood";
            this.lbl_Mood.Size = new System.Drawing.Size(188, 33);
            this.lbl_Mood.TabIndex = 20;
            this.lbl_Mood.Text = "Ваш настрій:";
            // 
            // Temperament
            // 
            this.Temperament.AutoSize = true;
            this.Temperament.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Temperament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Temperament.Location = new System.Drawing.Point(837, 27);
            this.Temperament.Name = "Temperament";
            this.Temperament.Size = new System.Drawing.Size(130, 33);
            this.Temperament.TabIndex = 21;
            this.Temperament.Text = "Холерик";
            // 
            // Mood
            // 
            this.Mood.AutoSize = true;
            this.Mood.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Mood.Location = new System.Drawing.Point(370, 60);
            this.Mood.Name = "Mood";
            this.Mood.Size = new System.Drawing.Size(130, 33);
            this.Mood.TabIndex = 22;
            this.Mood.Text = "Холерик";
            // 
            // OpenInBrowser
            // 
            this.OpenInBrowser.FlatAppearance.BorderSize = 0;
            this.OpenInBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenInBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.OpenInBrowser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.OpenInBrowser.Location = new System.Drawing.Point(376, 676);
            this.OpenInBrowser.Name = "OpenInBrowser";
            this.OpenInBrowser.Size = new System.Drawing.Size(519, 41);
            this.OpenInBrowser.TabIndex = 23;
            this.OpenInBrowser.Text = "Дізнатися більше про свій темперамент";
            this.OpenInBrowser.UseVisualStyleBackColor = true;
            this.OpenInBrowser.Click += new System.EventHandler(this.OpenInBrowser_Click);
            // 
            // Resultt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.OpenInBrowser);
            this.Controls.Add(this.Mood);
            this.Controls.Add(this.Temperament);
            this.Controls.Add(this.lbl_Mood);
            this.Controls.Add(this.lbl_Temperament);
            this.Controls.Add(this.Result2Text);
            this.Controls.Add(this.ResultIMG);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.CloseIMG);
            this.Name = "Resultt";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CloseIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultIMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CloseIMG;
        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.PictureBox ResultIMG;
        private System.Windows.Forms.TextBox Result2Text;
        private System.Windows.Forms.Label lbl_Temperament;
        private System.Windows.Forms.Label lbl_Mood;
        private System.Windows.Forms.Label Temperament;
        private System.Windows.Forms.Label Mood;
        private System.Windows.Forms.Button OpenInBrowser;
    }
}
