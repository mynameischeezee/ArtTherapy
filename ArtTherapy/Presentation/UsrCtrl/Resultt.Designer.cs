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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultt));
            this.pic = new System.Windows.Forms.PictureBox();
            this.lbl_Direction = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.TextBox();
            this.btn_OpenInBrowser = new System.Windows.Forms.Button();
            this.txtbox_About = new System.Windows.Forms.RichTextBox();
            this.txtbox_Direction = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(21, 97);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(300, 300);
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            // 
            // lbl_Direction
            // 
            this.lbl_Direction.AutoSize = true;
            this.lbl_Direction.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Direction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lbl_Direction.Location = new System.Drawing.Point(353, 89);
            this.lbl_Direction.Name = "lbl_Direction";
            this.lbl_Direction.Size = new System.Drawing.Size(251, 42);
            this.lbl_Direction.TabIndex = 2;
            this.lbl_Direction.Text = "Рідкий Акрил";
            // 
            // lbl_Header
            // 
            this.lbl_Header.BackColor = System.Drawing.Color.White;
            this.lbl_Header.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lbl_Header.Location = new System.Drawing.Point(21, 13);
            this.lbl_Header.Multiline = true;
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.ReadOnly = true;
            this.lbl_Header.Size = new System.Drawing.Size(1118, 64);
            this.lbl_Header.TabIndex = 4;
            this.lbl_Header.Text = "За результатом тесту ваш темперамент [ТЕМПЕРАМЕНТ] і ви перебуваєте у стані [СТАН" +
    "]. \r\nІдеальний вид терапії для вас це:\r\n";
            // 
            // btn_OpenInBrowser
            // 
            this.btn_OpenInBrowser.FlatAppearance.BorderSize = 0;
            this.btn_OpenInBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenInBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_OpenInBrowser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btn_OpenInBrowser.Location = new System.Drawing.Point(334, 553);
            this.btn_OpenInBrowser.Name = "btn_OpenInBrowser";
            this.btn_OpenInBrowser.Size = new System.Drawing.Size(500, 41);
            this.btn_OpenInBrowser.TabIndex = 6;
            this.btn_OpenInBrowser.Text = "Дізнатися більше про свій темперамент";
            this.btn_OpenInBrowser.UseVisualStyleBackColor = true;
            this.btn_OpenInBrowser.Click += new System.EventHandler(this.btn_OpenInBrowser_Click);
            // 
            // txtbox_About
            // 
            this.txtbox_About.BackColor = System.Drawing.Color.White;
            this.txtbox_About.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtbox_About.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbox_About.Location = new System.Drawing.Point(360, 155);
            this.txtbox_About.Name = "txtbox_About";
            this.txtbox_About.ReadOnly = true;
            this.txtbox_About.Size = new System.Drawing.Size(779, 242);
            this.txtbox_About.TabIndex = 7;
            this.txtbox_About.Text = resources.GetString("txtbox_About.Text");
            // 
            // txtbox_Direction
            // 
            this.txtbox_Direction.BackColor = System.Drawing.Color.White;
            this.txtbox_Direction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_Direction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbox_Direction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbox_Direction.Location = new System.Drawing.Point(21, 428);
            this.txtbox_Direction.Name = "txtbox_Direction";
            this.txtbox_Direction.ReadOnly = true;
            this.txtbox_Direction.Size = new System.Drawing.Size(1118, 128);
            this.txtbox_Direction.TabIndex = 8;
            this.txtbox_Direction.Text = resources.GetString("txtbox_Direction.Text");
            // 
            // Resultt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtbox_Direction);
            this.Controls.Add(this.txtbox_About);
            this.Controls.Add(this.btn_OpenInBrowser);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.lbl_Direction);
            this.Controls.Add(this.pic);
            this.Name = "Resultt";
            this.Size = new System.Drawing.Size(1152, 618);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label lbl_Direction;
        private System.Windows.Forms.TextBox lbl_Header;
        private System.Windows.Forms.Button btn_OpenInBrowser;
        private System.Windows.Forms.RichTextBox txtbox_About;
        private System.Windows.Forms.RichTextBox txtbox_Direction;
    }
}
