namespace Bài_4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstLop = new System.Windows.Forms.ListBox();
            this.dateTimeNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnCapNhatItem = new System.Windows.Forms.Button();
            this.btnXoaItem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clnMa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilsNho = new System.Windows.Forms.ImageList(this.components);
            this.ilsLon = new System.Windows.Forms.ImageList(this.components);
            this.ilsminion = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstLop);
            this.groupBox1.Controls.Add(this.dateTimeNgaySinh);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMaSv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // lstLop
            // 
            this.lstLop.FormattingEnabled = true;
            this.lstLop.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.lstLop.Location = new System.Drawing.Point(88, 155);
            this.lstLop.Name = "lstLop";
            this.lstLop.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstLop.Size = new System.Drawing.Size(108, 17);
            this.lstLop.TabIndex = 11;
            this.lstLop.SelectedIndexChanged += new System.EventHandler(this.ltbLop_SelectedIndexChanged);
            // 
            // dateTimeNgaySinh
            // 
            this.dateTimeNgaySinh.Location = new System.Drawing.Point(88, 122);
            this.dateTimeNgaySinh.Name = "dateTimeNgaySinh";
            this.dateTimeNgaySinh.Size = new System.Drawing.Size(108, 20);
            this.dateTimeNgaySinh.TabIndex = 10;
            this.dateTimeNgaySinh.Value = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            this.dateTimeNgaySinh.ValueChanged += new System.EventHandler(this.dateTimeNgaySinh_ValueChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(88, 92);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(108, 20);
            this.txtDiaChi.TabIndex = 7;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(88, 61);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(108, 20);
            this.txtHoTen.TabIndex = 6;
            this.txtHoTen.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtMaSv
            // 
            this.txtMaSv.Location = new System.Drawing.Point(88, 35);
            this.txtMaSv.Name = "txtMaSv";
            this.txtMaSv.Size = new System.Drawing.Size(108, 20);
            this.txtMaSv.TabIndex = 5;
            this.txtMaSv.TextChanged += new System.EventHandler(this.txtMaSv_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.DarkGray;
            this.btnThemMoi.Location = new System.Drawing.Point(304, 42);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 36);
            this.btnThemMoi.TabIndex = 2;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnCapNhatItem
            // 
            this.btnCapNhatItem.BackColor = System.Drawing.Color.DarkGray;
            this.btnCapNhatItem.Location = new System.Drawing.Point(304, 88);
            this.btnCapNhatItem.Name = "btnCapNhatItem";
            this.btnCapNhatItem.Size = new System.Drawing.Size(75, 36);
            this.btnCapNhatItem.TabIndex = 3;
            this.btnCapNhatItem.Text = "Cập Nhật Item";
            this.btnCapNhatItem.UseVisualStyleBackColor = false;
            this.btnCapNhatItem.Click += new System.EventHandler(this.btnCapNhatItem_Click);
            // 
            // btnXoaItem
            // 
            this.btnXoaItem.BackColor = System.Drawing.Color.DarkGray;
            this.btnXoaItem.Location = new System.Drawing.Point(304, 133);
            this.btnXoaItem.Name = "btnXoaItem";
            this.btnXoaItem.Size = new System.Drawing.Size(75, 36);
            this.btnXoaItem.TabIndex = 4;
            this.btnXoaItem.Text = "Xóa Item";
            this.btnXoaItem.UseVisualStyleBackColor = false;
            this.btnXoaItem.Click += new System.EventHandler(this.btnXoaItem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkGray;
            this.btnThoat.Location = new System.Drawing.Point(304, 182);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 36);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnMa,
            this.clnHoTen,
            this.clnDiaChi,
            this.clnNgaySinh,
            this.clnLop});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 228);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(390, 97);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // clnMa
            // 
            this.clnMa.Text = "Mã";
            this.clnMa.Width = 53;
            // 
            // clnHoTen
            // 
            this.clnHoTen.Text = "Họ Tên ";
            this.clnHoTen.Width = 104;
            // 
            // clnDiaChi
            // 
            this.clnDiaChi.Text = "Địa Chỉ";
            this.clnDiaChi.Width = 112;
            // 
            // clnNgaySinh
            // 
            this.clnNgaySinh.Text = "Ngày Sinh";
            this.clnNgaySinh.Width = 88;
            // 
            // clnLop
            // 
            this.clnLop.Text = "Lớp";
            this.clnLop.Width = 85;
            // 
            // ilsNho
            // 
            this.ilsNho.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsNho.ImageStream")));
            this.ilsNho.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsNho.Images.SetKeyName(0, "png-clipart-despicable-me-minion-dr-nefario-tim-the-minion-youtube-despicable-me-" +
        "film-minions-bob-ursinho-heroes-tim-the-minion-thumbnail.png");
            // 
            // ilsLon
            // 
            this.ilsLon.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilsLon.ImageSize = new System.Drawing.Size(24, 24);
            this.ilsLon.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ilsminion
            // 
            this.ilsminion.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsminion.ImageStream")));
            this.ilsminion.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsminion.Images.SetKeyName(0, "png-clipart-despicable-me-minion-dr-nefario-tim-the-minion-youtube-despicable-me-" +
        "film-minions-bob-ursinho-heroes-tim-the-minion-thumbnail.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 374);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaItem);
            this.Controls.Add(this.btnCapNhatItem);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSv;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnCapNhatItem;
        private System.Windows.Forms.Button btnXoaItem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clnMa;
        private System.Windows.Forms.ColumnHeader clnHoTen;
        private System.Windows.Forms.ColumnHeader clnDiaChi;
        private System.Windows.Forms.ColumnHeader clnNgaySinh;
        private System.Windows.Forms.ColumnHeader clnLop;
        private System.Windows.Forms.ImageList ilsNho;
        private System.Windows.Forms.ImageList ilsLon;
        private System.Windows.Forms.ImageList ilsminion;
        private System.Windows.Forms.ListBox lstLop;
        private System.Windows.Forms.DateTimePicker dateTimeNgaySinh;
    }
}

