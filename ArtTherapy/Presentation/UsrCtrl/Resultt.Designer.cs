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
            this.ResultText.Location = new System.Drawing.Point(182, 55);
            this.ResultText.Multiline = true;
            this.ResultText.Name = "ResultText";
            this.ResultText.ReadOnly = true;
            this.ResultText.Size = new System.Drawing.Size(864, 234);
            this.ResultText.TabIndex = 16;
            this.ResultText.Text = "Hello";
            // 
            // ResultIMG
            // 
            this.ResultIMG.Location = new System.Drawing.Point(182, 295);
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
            this.Result2Text.Location = new System.Drawing.Point(488, 295);
            this.Result2Text.Multiline = true;
            this.Result2Text.Name = "Result2Text";
            this.Result2Text.ReadOnly = true;
            this.Result2Text.Size = new System.Drawing.Size(558, 300);
            this.Result2Text.TabIndex = 18;
            this.Result2Text.Text = "Hello";
            // 
            // Resultt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
    }
}
