using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void radchuthuong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radCHUINHOA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                txtName.Clear();        
                txtResult.Clear();     
                radchuthuong.Checked = true;
                txtName.Focus();   
            }
        }
        private void btnResult_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if ( name == null || name == "")
            {
                MessageBox.Show("Vui lòng nhập họ và tên");
                return;
            }
            if (radchuthuong.Checked == true)
            {
                txtResult.Text = name.ToLower();
            }
            else if (radCHUINHOA.Checked == true)
            {
                txtResult.Text = name.ToUpper();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn kiểu chữ");
            }
        }
        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
