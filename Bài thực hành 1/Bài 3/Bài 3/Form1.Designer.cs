namespace Bài_3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.cboSo = new System.Windows.Forms.ComboBox();
            this.listUoc = new System.Windows.Forms.ListBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTongcacuocso = new System.Windows.Forms.Button();
            this.btnSoluongcacuocsochan = new System.Windows.Forms.Button();
            this.btnSoluongcacuocsonguyen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.cboSo);
            this.groupBox1.Controls.Add(this.txtSo);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(264, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Số";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listUoc);
            this.groupBox2.Location = new System.Drawing.Point(327, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(264, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(9, 47);
            this.txtSo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(133, 26);
            this.txtSo.TabIndex = 0;
            this.txtSo.TextChanged += new System.EventHandler(this.txtSo_TextChanged);
            // 
            // cboSo
            // 
            this.cboSo.FormattingEnabled = true;
            this.cboSo.Location = new System.Drawing.Point(9, 104);
            this.cboSo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboSo.Name = "cboSo";
            this.cboSo.Size = new System.Drawing.Size(240, 27);
            this.cboSo.TabIndex = 1;
            this.cboSo.SelectedIndexChanged += new System.EventHandler(this.cboSo_SelectedIndexChanged);
            // 
            // listUoc
            // 
            this.listUoc.FormattingEnabled = true;
            this.listUoc.ItemHeight = 19;
            this.listUoc.Location = new System.Drawing.Point(9, 34);
            this.listUoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listUoc.Name = "listUoc";
            this.listUoc.Size = new System.Drawing.Size(244, 99);
            this.listUoc.TabIndex = 0;
            this.listUoc.SelectedIndexChanged += new System.EventHandler(this.listUoc_SelectedIndexChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCapNhat.Location = new System.Drawing.Point(165, 42);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(90, 37);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "&Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThoat.Location = new System.Drawing.Point(190, 341);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 38);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTongcacuocso
            // 
            this.btnTongcacuocso.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTongcacuocso.Location = new System.Drawing.Point(336, 203);
            this.btnTongcacuocso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTongcacuocso.Name = "btnTongcacuocso";
            this.btnTongcacuocso.Size = new System.Drawing.Size(255, 51);
            this.btnTongcacuocso.TabIndex = 3;
            this.btnTongcacuocso.Text = "&Tổng các ước số";
            this.btnTongcacuocso.UseVisualStyleBackColor = false;
            this.btnTongcacuocso.Click += new System.EventHandler(this.btnTongcacuocso_Click);
            // 
            // btnSoluongcacuocsochan
            // 
            this.btnSoluongcacuocsochan.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSoluongcacuocsochan.Location = new System.Drawing.Point(336, 267);
            this.btnSoluongcacuocsochan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSoluongcacuocsochan.Name = "btnSoluongcacuocsochan";
            this.btnSoluongcacuocsochan.Size = new System.Drawing.Size(255, 51);
            this.btnSoluongcacuocsochan.TabIndex = 4;
            this.btnSoluongcacuocsochan.Text = "&Số lượng các ước số chẵn";
            this.btnSoluongcacuocsochan.UseVisualStyleBackColor = false;
            this.btnSoluongcacuocsochan.Click += new System.EventHandler(this.btnSoluongcacuocsochan_Click);
            // 
            // btnSoluongcacuocsonguyen
            // 
            this.btnSoluongcacuocsonguyen.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSoluongcacuocsonguyen.Location = new System.Drawing.Point(336, 327);
            this.btnSoluongcacuocsonguyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSoluongcacuocsonguyen.Name = "btnSoluongcacuocsonguyen";
            this.btnSoluongcacuocsonguyen.Size = new System.Drawing.Size(255, 51);
            this.btnSoluongcacuocsonguyen.TabIndex = 5;
            this.btnSoluongcacuocsonguyen.Text = "Số lượng các ước số &nguyên tố";
            this.btnSoluongcacuocsonguyen.UseVisualStyleBackColor = false;
            this.btnSoluongcacuocsonguyen.Click += new System.EventHandler(this.btnSoluongcacuocsonguyen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 430);
            this.Controls.Add(this.btnSoluongcacuocsonguyen);
            this.Controls.Add(this.btnSoluongcacuocsochan);
            this.Controls.Add(this.btnTongcacuocso);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ComboBox cboSo;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listUoc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTongcacuocso;
        private System.Windows.Forms.Button btnSoluongcacuocsochan;
        private System.Windows.Forms.Button btnSoluongcacuocsonguyen;
    }
}

