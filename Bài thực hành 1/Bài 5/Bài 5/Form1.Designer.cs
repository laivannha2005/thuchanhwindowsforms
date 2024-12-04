namespace Bài_5
{
    partial class groupBox2
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.chkDamBold = new System.Windows.Forms.CheckBox();
            this.chkNghiengItalic = new System.Windows.Forms.CheckBox();
            this.chkGachChan = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhapten = new System.Windows.Forms.TextBox();
            this.txtLaptrinhboi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Tên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBlack);
            this.groupBox1.Controls.Add(this.radBlue);
            this.groupBox1.Controls.Add(this.radGreen);
            this.groupBox1.Controls.Add(this.radRed);
            this.groupBox1.Location = new System.Drawing.Point(34, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(140, 191);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // groupBox21
            // 
            this.groupBox21.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox21.Controls.Add(this.chkGachChan);
            this.groupBox21.Controls.Add(this.chkNghiengItalic);
            this.groupBox21.Controls.Add(this.chkDamBold);
            this.groupBox21.Location = new System.Drawing.Point(230, 82);
            this.groupBox21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox21.Size = new System.Drawing.Size(156, 191);
            this.groupBox21.TabIndex = 2;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Forn";
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(9, 44);
            this.radRed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(52, 23);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.radGreen.Location = new System.Drawing.Point(9, 77);
            this.radGreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(64, 23);
            this.radGreen.TabIndex = 1;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radBlue.Location = new System.Drawing.Point(9, 111);
            this.radBlue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(54, 23);
            this.radBlue.TabIndex = 2;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Location = new System.Drawing.Point(9, 145);
            this.radBlack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(62, 23);
            this.radBlack.TabIndex = 3;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
            // 
            // chkDamBold
            // 
            this.chkDamBold.AutoSize = true;
            this.chkDamBold.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDamBold.ForeColor = System.Drawing.Color.Blue;
            this.chkDamBold.Location = new System.Drawing.Point(14, 34);
            this.chkDamBold.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDamBold.Name = "chkDamBold";
            this.chkDamBold.Size = new System.Drawing.Size(95, 23);
            this.chkDamBold.TabIndex = 0;
            this.chkDamBold.Text = "Đậm Bold";
            this.chkDamBold.UseVisualStyleBackColor = true;
            this.chkDamBold.CheckedChanged += new System.EventHandler(this.chkDamBold_CheckedChanged);
            // 
            // chkNghiengItalic
            // 
            this.chkNghiengItalic.AutoSize = true;
            this.chkNghiengItalic.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNghiengItalic.ForeColor = System.Drawing.Color.Blue;
            this.chkNghiengItalic.Location = new System.Drawing.Point(14, 67);
            this.chkNghiengItalic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkNghiengItalic.Name = "chkNghiengItalic";
            this.chkNghiengItalic.Size = new System.Drawing.Size(126, 23);
            this.chkNghiengItalic.TabIndex = 1;
            this.chkNghiengItalic.Text = "Nghiêng Italic";
            this.chkNghiengItalic.UseVisualStyleBackColor = true;
            this.chkNghiengItalic.CheckedChanged += new System.EventHandler(this.chkNghiengItalic_CheckedChanged);
            // 
            // chkGachChan
            // 
            this.chkGachChan.AutoSize = true;
            this.chkGachChan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGachChan.ForeColor = System.Drawing.Color.Blue;
            this.chkGachChan.Location = new System.Drawing.Point(14, 98);
            this.chkGachChan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkGachChan.Name = "chkGachChan";
            this.chkGachChan.Size = new System.Drawing.Size(96, 23);
            this.chkGachChan.TabIndex = 2;
            this.chkGachChan.Text = "Gạch Chân";
            this.chkGachChan.UseVisualStyleBackColor = true;
            this.chkGachChan.CheckedChanged += new System.EventHandler(this.chkGachChan_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(40, 330);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lập Trình Bởi";
            // 
            // txtNhapten
            // 
            this.txtNhapten.Location = new System.Drawing.Point(121, 20);
            this.txtNhapten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNhapten.Name = "txtNhapten";
            this.txtNhapten.Size = new System.Drawing.Size(208, 26);
            this.txtNhapten.TabIndex = 5;
            this.txtNhapten.TextChanged += new System.EventHandler(this.txtNhapten_TextChanged);
            // 
            // txtLaptrinhboi
            // 
            this.txtLaptrinhboi.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtLaptrinhboi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLaptrinhboi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLaptrinhboi.Location = new System.Drawing.Point(153, 326);
            this.txtLaptrinhboi.Margin = new System.Windows.Forms.Padding(4);
            this.txtLaptrinhboi.Name = "txtLaptrinhboi";
            this.txtLaptrinhboi.Size = new System.Drawing.Size(208, 26);
            this.txtLaptrinhboi.TabIndex = 4;
            this.txtLaptrinhboi.TextChanged += new System.EventHandler(this.txtLaptrinhboi_TextChanged);
            // 
            // groupBox2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(534, 438);
            this.Controls.Add(this.txtNhapten);
            this.Controls.Add(this.txtLaptrinhboi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox21);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "groupBox2";
            this.Text = "Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.CheckBox chkGachChan;
        private System.Windows.Forms.CheckBox chkNghiengItalic;
        private System.Windows.Forms.CheckBox chkDamBold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhapten;
        private System.Windows.Forms.TextBox txtLaptrinhboi;
    }
}

