namespace Bài_2
{
    partial class Form1
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
            this.lblNhaphovaten = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.radchuthuong = new System.Windows.Forms.RadioButton();
            this.radCHUINHOA = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNhaphovaten
            // 
            this.lblNhaphovaten.AutoSize = true;
            this.lblNhaphovaten.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaphovaten.Location = new System.Drawing.Point(39, 47);
            this.lblNhaphovaten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhaphovaten.Name = "lblNhaphovaten";
            this.lblNhaphovaten.Size = new System.Drawing.Size(116, 19);
            this.lblNhaphovaten.TabIndex = 0;
            this.lblNhaphovaten.Text = "Nhập họ và tên:";
            this.lblNhaphovaten.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radCHUINHOA);
            this.groupBox1.Controls.Add(this.radchuthuong);
            this.groupBox1.Location = new System.Drawing.Point(44, 117);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(440, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Kiểu Chữ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(188, 42);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(390, 26);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.Silver;
            this.btnClean.Location = new System.Drawing.Point(492, 117);
            this.btnClean.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(87, 136);
            this.btnClean.TabIndex = 3;
            this.btnClean.Text = "Xóa";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.Silver;
            this.btnResult.Location = new System.Drawing.Point(44, 276);
            this.btnResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(138, 29);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "Kết Quả";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(190, 278);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(390, 26);
            this.txtResult.TabIndex = 5;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // radchuthuong
            // 
            this.radchuthuong.AutoSize = true;
            this.radchuthuong.Location = new System.Drawing.Point(34, 44);
            this.radchuthuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radchuthuong.Name = "radchuthuong";
            this.radchuthuong.Size = new System.Drawing.Size(96, 23);
            this.radchuthuong.TabIndex = 0;
            this.radchuthuong.TabStop = true;
            this.radchuthuong.Text = "chữ thường";
            this.radchuthuong.UseVisualStyleBackColor = true;
            this.radchuthuong.CheckedChanged += new System.EventHandler(this.radchuthuong_CheckedChanged);
            // 
            // radCHUINHOA
            // 
            this.radCHUINHOA.AutoSize = true;
            this.radCHUINHOA.Location = new System.Drawing.Point(34, 77);
            this.radCHUINHOA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radCHUINHOA.Name = "radCHUINHOA";
            this.radCHUINHOA.Size = new System.Drawing.Size(120, 23);
            this.radCHUINHOA.TabIndex = 1;
            this.radCHUINHOA.TabStop = true;
            this.radCHUINHOA.Text = "CHỮ IN HOA";
            this.radCHUINHOA.UseVisualStyleBackColor = true;
            this.radCHUINHOA.CheckedChanged += new System.EventHandler(this.radCHUINHOA_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 329);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNhaphovaten);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhaphovaten;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.RadioButton radCHUINHOA;
        private System.Windows.Forms.RadioButton radchuthuong;
    }
}

