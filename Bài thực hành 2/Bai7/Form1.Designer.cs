namespace Bai7
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhapten = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnCapkhoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(34, 64);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(353, 397);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên";
            // 
            // txtNhapten
            // 
            this.txtNhapten.Location = new System.Drawing.Point(621, 20);
            this.txtNhapten.Name = "txtNhapten";
            this.txtNhapten.Size = new System.Drawing.Size(242, 28);
            this.txtNhapten.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(892, 12);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(96, 43);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(416, 64);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(530, 397);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnCapkhoa
            // 
            this.btnCapkhoa.Location = new System.Drawing.Point(792, 488);
            this.btnCapkhoa.Name = "btnCapkhoa";
            this.btnCapkhoa.Size = new System.Drawing.Size(153, 42);
            this.btnCapkhoa.TabIndex = 5;
            this.btnCapkhoa.Text = "Cấp Khoa";
            this.btnCapkhoa.UseVisualStyleBackColor = true;
            this.btnCapkhoa.Click += new System.EventHandler(this.btnCapkhoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.btnCapkhoa);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtNhapten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapten;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnCapkhoa;
    }
}

