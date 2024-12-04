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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radVietnam = new System.Windows.Forms.RadioButton();
            this.radUSA = new System.Windows.Forms.RadioButton();
            this.radItalia = new System.Windows.Forms.RadioButton();
            this.radPhilippine = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radPhilippine);
            this.groupBox1.Controls.Add(this.radItalia);
            this.groupBox1.Controls.Add(this.radUSA);
            this.groupBox1.Controls.Add(this.radVietnam);
            this.groupBox1.Location = new System.Drawing.Point(47, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(785, 92);
            this.label1.TabIndex = 1;
            this.label1.Text = "COUNTRY FLAGS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radVietnam
            // 
            this.radVietnam.AutoSize = true;
            this.radVietnam.Location = new System.Drawing.Point(15, 37);
            this.radVietnam.Name = "radVietnam";
            this.radVietnam.Size = new System.Drawing.Size(63, 17);
            this.radVietnam.TabIndex = 0;
            this.radVietnam.TabStop = true;
            this.radVietnam.Text = "Vietnam";
            this.radVietnam.UseVisualStyleBackColor = true;
            this.radVietnam.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radUSA
            // 
            this.radUSA.AutoSize = true;
            this.radUSA.Location = new System.Drawing.Point(15, 74);
            this.radUSA.Name = "radUSA";
            this.radUSA.Size = new System.Drawing.Size(47, 17);
            this.radUSA.TabIndex = 1;
            this.radUSA.TabStop = true;
            this.radUSA.Text = "USA";
            this.radUSA.UseVisualStyleBackColor = true;
            this.radUSA.CheckedChanged += new System.EventHandler(this.radUSA_CheckedChanged);
            // 
            // radItalia
            // 
            this.radItalia.AutoSize = true;
            this.radItalia.Location = new System.Drawing.Point(15, 111);
            this.radItalia.Name = "radItalia";
            this.radItalia.Size = new System.Drawing.Size(47, 17);
            this.radItalia.TabIndex = 2;
            this.radItalia.TabStop = true;
            this.radItalia.Text = "Italia";
            this.radItalia.UseVisualStyleBackColor = true;
            this.radItalia.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radPhilippine
            // 
            this.radPhilippine.AutoSize = true;
            this.radPhilippine.Location = new System.Drawing.Point(16, 145);
            this.radPhilippine.Name = "radPhilippine";
            this.radPhilippine.Size = new System.Drawing.Size(70, 17);
            this.radPhilippine.TabIndex = 3;
            this.radPhilippine.TabStop = true;
            this.radPhilippine.Text = "Philippine";
            this.radPhilippine.UseVisualStyleBackColor = true;
            this.radPhilippine.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::Bài_2.Properties.Resources.download__2_;
            this.pictureBox4.Location = new System.Drawing.Point(455, 126);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(210, 196);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::Bài_2.Properties.Resources.download__1_;
            this.pictureBox3.Location = new System.Drawing.Point(455, 126);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(210, 196);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Bài_2.Properties.Resources.download__3_;
            this.pictureBox2.Location = new System.Drawing.Point(455, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Bài_2.Properties.Resources.download;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(455, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 415);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "frmQuocGia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radPhilippine;
        private System.Windows.Forms.RadioButton radItalia;
        private System.Windows.Forms.RadioButton radUSA;
        private System.Windows.Forms.RadioButton radVietnam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

