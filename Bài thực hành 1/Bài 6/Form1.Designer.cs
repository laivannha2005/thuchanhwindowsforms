namespace Bài_6
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
            this.labNhap = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radtime = new System.Windows.Forms.RadioButton();
            this.radArial = new System.Windows.Forms.RadioButton();
            this.radTahoma = new System.Windows.Forms.RadioButton();
            this.radCourier = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labNhap
            // 
            this.labNhap.AutoSize = true;
            this.labNhap.Location = new System.Drawing.Point(59, 48);
            this.labNhap.Name = "labNhap";
            this.labNhap.Size = new System.Drawing.Size(94, 16);
            this.labNhap.TabIndex = 0;
            this.labNhap.Text = "Nhập Văn Bản";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(62, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 273);
            this.textBox1.TabIndex = 1;
            // 
            // radtime
            // 
            this.radtime.AutoSize = true;
            this.radtime.Location = new System.Drawing.Point(428, 137);
            this.radtime.Name = "radtime";
            this.radtime.Size = new System.Drawing.Size(143, 20);
            this.radtime.TabIndex = 2;
            this.radtime.TabStop = true;
            this.radtime.Text = "Times New Roman";
            this.radtime.UseVisualStyleBackColor = true;
            this.radtime.CheckedChanged += new System.EventHandler(this.radtime_CheckedChanged);
            // 
            // radArial
            // 
            this.radArial.AutoSize = true;
            this.radArial.Location = new System.Drawing.Point(428, 201);
            this.radArial.Name = "radArial";
            this.radArial.Size = new System.Drawing.Size(55, 20);
            this.radArial.TabIndex = 3;
            this.radArial.TabStop = true;
            this.radArial.Text = "Arial";
            this.radArial.UseVisualStyleBackColor = true;
            this.radArial.CheckedChanged += new System.EventHandler(this.radArial_CheckedChanged);
            // 
            // radTahoma
            // 
            this.radTahoma.AutoSize = true;
            this.radTahoma.Location = new System.Drawing.Point(428, 259);
            this.radTahoma.Name = "radTahoma";
            this.radTahoma.Size = new System.Drawing.Size(79, 20);
            this.radTahoma.TabIndex = 4;
            this.radTahoma.TabStop = true;
            this.radTahoma.Text = "Tahoma";
            this.radTahoma.UseVisualStyleBackColor = true;
            this.radTahoma.CheckedChanged += new System.EventHandler(this.radTahoma_CheckedChanged);
            // 
            // radCourier
            // 
            this.radCourier.AutoSize = true;
            this.radCourier.Location = new System.Drawing.Point(428, 314);
            this.radCourier.Name = "radCourier";
            this.radCourier.Size = new System.Drawing.Size(101, 20);
            this.radCourier.TabIndex = 5;
            this.radCourier.TabStop = true;
            this.radCourier.Text = "Courier New";
            this.radCourier.UseVisualStyleBackColor = true;
            this.radCourier.CheckedChanged += new System.EventHandler(this.radCourier_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radCourier);
            this.Controls.Add(this.radTahoma);
            this.Controls.Add(this.radArial);
            this.Controls.Add(this.radtime);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labNhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNhap;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radtime;
        private System.Windows.Forms.RadioButton radArial;
        private System.Windows.Forms.RadioButton radTahoma;
        private System.Windows.Forms.RadioButton radCourier;
        private System.Windows.Forms.Button button1;
    }
}

