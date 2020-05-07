namespace ArtTherapy.Presentation.UsrCtrl
{
    partial class QuestionPart2
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
            this.QuestionNumber = new System.Windows.Forms.Label();
            this.QuestionText = new System.Windows.Forms.TextBox();
            this.PartText = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Answer3 = new System.Windows.Forms.RadioButton();
            this.Answer2 = new System.Windows.Forms.RadioButton();
            this.Answer1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // QuestionNumber
            // 
            this.QuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QuestionNumber.Location = new System.Drawing.Point(11, 28);
            this.QuestionNumber.Name = "QuestionNumber";
            this.QuestionNumber.Size = new System.Drawing.Size(136, 22);
            this.QuestionNumber.TabIndex = 16;
            this.QuestionNumber.Text = "Частина 1.";
            // 
            // QuestionText
            // 
            this.QuestionText.BackColor = System.Drawing.Color.White;
            this.QuestionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionText.Enabled = false;
            this.QuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QuestionText.Location = new System.Drawing.Point(56, 125);
            this.QuestionText.Multiline = true;
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.ReadOnly = true;
            this.QuestionText.Size = new System.Drawing.Size(864, 109);
            this.QuestionText.TabIndex = 15;
            this.QuestionText.Text = "Hello";
            // 
            // PartText
            // 
            this.PartText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PartText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PartText.Location = new System.Drawing.Point(11, 6);
            this.PartText.Name = "PartText";
            this.PartText.Size = new System.Drawing.Size(136, 22);
            this.PartText.TabIndex = 14;
            this.PartText.Text = "Частина 2.";
            // 
            // Next
            // 
            this.Next.FlatAppearance.BorderSize = 0;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Next.Location = new System.Drawing.Point(1043, 571);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(99, 41);
            this.Next.TabIndex = 13;
            this.Next.Text = "Далі >";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Answer3
            // 
            this.Answer3.AutoSize = true;
            this.Answer3.FlatAppearance.BorderSize = 0;
            this.Answer3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gold;
            this.Answer3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Answer3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.Answer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Answer3.Location = new System.Drawing.Point(56, 320);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(676, 29);
            this.Answer3.TabIndex = 11;
            this.Answer3.Text = "Енергійний, невгамовний, пустотливий, гарячий, задерикуватий.";
            this.Answer3.UseVisualStyleBackColor = true;
            this.Answer3.CheckedChanged += new System.EventHandler(this.Answer3_CheckedChanged);
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.FlatAppearance.BorderSize = 0;
            this.Answer2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gold;
            this.Answer2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Answer2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.Answer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Answer2.Location = new System.Drawing.Point(56, 280);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(535, 29);
            this.Answer2.TabIndex = 10;
            this.Answer2.Text = "Вразливий, сором\'язливий, уразливий, нерішучий.";
            this.Answer2.UseVisualStyleBackColor = true;
            this.Answer2.CheckedChanged += new System.EventHandler(this.Answer2_CheckedChanged);
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Answer1.FlatAppearance.BorderSize = 0;
            this.Answer1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Answer1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Answer1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Answer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Answer1.Location = new System.Drawing.Point(56, 240);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(543, 29);
            this.Answer1.TabIndex = 9;
            this.Answer1.Text = "Cпокійний, приземлений, стриманий, миролюбний.";
            this.Answer1.UseVisualStyleBackColor = true;
            this.Answer1.CheckedChanged += new System.EventHandler(this.Answer1_CheckedChanged);
            // 
            // QuestionPart2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.QuestionNumber);
            this.Controls.Add(this.QuestionText);
            this.Controls.Add(this.PartText);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.Answer1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "QuestionPart2";
            this.Size = new System.Drawing.Size(1152, 618);
            this.Load += new System.EventHandler(this.QuestionPart2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionNumber;
        private System.Windows.Forms.TextBox QuestionText;
        private System.Windows.Forms.Label PartText;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.RadioButton Answer3;
        private System.Windows.Forms.RadioButton Answer2;
        private System.Windows.Forms.RadioButton Answer1;
    }
}
