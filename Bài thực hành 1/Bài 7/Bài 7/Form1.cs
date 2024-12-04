using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bài_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtYearofbirth_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            bool a = true;
            if (txtYourName.Text == "")
            {
                errorProvider1.SetError(txtYourName, "Tên không được để trống.");
                a = false;
            }
            int birthYear;
            if (!int.TryParse(txtYearofbirth.Text, out birthYear))
            {
                errorProvider2.SetError(txtYearofbirth, "Nhập với số.");
                a = false;
            }
            if (a == true)
            {
                int namhientai = DateTime.Now.Year;
                int namsinh = namhientai - birthYear;
                MessageBox.Show($"Tên: {txtYourName.Text}\nTuổi: {namsinh}", "Thông tin người dùng");
            }
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txtYearofbirth.Clear();
            errorProvider1.Clear();
            errorProvider2.Clear();
            txtYourName.Focus();
        }
    }
}
