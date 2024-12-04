using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ValidateInput()
        {
            errorProvider1.Clear();
            if (txtNhapA.Text == "")
            {
                errorProvider1.SetError(txtNhapA, "A không được để trống.");
                btnGiai.Enabled = false;
                return;
            }
            double a;
            if (!double.TryParse(txtNhapA.Text, out a))
            {
                errorProvider1.SetError(txtNhapA, "Vui lòng nhập số cho A.");
                btnGiai.Enabled = false;
                return; 
            }
            if (txtNhapB.Text == "")
            {
                errorProvider1.SetError(txtNhapB, "B không được để trống.");
                btnGiai.Enabled = false;
                return;  
            }
            double b;
            if (!double.TryParse(txtNhapB.Text, out b))
            {
                errorProvider1.SetError(txtNhapB, "Vui lòng nhập số cho B.");
                btnGiai.Enabled = false;
                return; 
            }
            btnGiai.Enabled = true;
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNhapA_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void txtNhapB_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }
        private void txtNghiemphuongtrinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNhapA.Text);
            double b = double.Parse(txtNhapB.Text);
            if (a == 0)
            {
                if (b == 0)
                {
                    txtNghiemphuongtrinh.Text = "Phương trình có vô số nghiệm.";
                }
                else
                {
                    txtNghiemphuongtrinh.Text = "Phương trình vô nghiệm.";
                }
            }
            else
            {
                double x = -b / a;
                txtNghiemphuongtrinh.Text = $"Nghiệm: {x}";
            }
            btnGiai.Enabled = false;
            btnXoa.Enabled = true;
            txtNhapA.Focus();
            btnXoa.Enabled = false;
            btnGiai.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhapA.Clear();
            txtNhapB.Clear();
            txtNghiemphuongtrinh.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGiai.Enabled = false; 
            btnXoa.Enabled = false;
        }
    }
}
