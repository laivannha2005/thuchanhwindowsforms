using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radCong_CheckedChanged(object sender, EventArgs e)
        {
            if (radCong.Checked == true)
            {
                double so1, so2;
                if (txtSo1.Text == "" || txtSo2.Text == "")
                {
                    txtKetQua.Text = "Vui lòng nhập đủ 2 số";
                    return;
                }
                try
                {
                    so1 = Convert.ToDouble(txtSo1.Text);
                    so2 = Convert.ToDouble(txtSo2.Text);
                }
                catch
                {
                    txtKetQua.Text = "Giá trị nhập không hợp lệ";
                    return;
                }
                double ketqua = so1 + so2;
                txtKetQua.Text = ketqua.ToString();
            }
        }
        private void radTru_CheckedChanged(object sender, EventArgs e)
        {
            if (radTru.Checked == true)
            {
                double so1, so2;
                if (txtSo1.Text == "" || txtSo2.Text == "")
                {
                    txtKetQua.Text = "Vui lòng nhập đủ 2 số";
                    return;
                }
                try
                {
                    so1 = Convert.ToDouble(txtSo1.Text);
                    so2 = Convert.ToDouble(txtSo2.Text);
                }
                catch
                {
                    txtKetQua.Text = "Giá trị nhập không hợp lệ";
                    return;
                }
                double ketqua = so1 - so2;
                txtKetQua.Text = ketqua.ToString();
            }
        }
        private void radNhan_CheckedChanged(object sender, EventArgs e)
        {
            if (radNhan.Checked == true)
            {
                double so1, so2;
                if (txtSo1.Text == "" || txtSo2.Text == "")
                {
                    txtKetQua.Text = "Vui lòng nhập đủ 2 số";
                    return;
                }
                try
                {
                    so1 = Convert.ToDouble(txtSo1.Text);
                    so2 = Convert.ToDouble(txtSo2.Text);
                }
                catch
                {
                    txtKetQua.Text = "Giá trị nhập không hợp lệ";
                    return;
                }
                double ketqua = so1 * so2;
                txtKetQua.Text = ketqua.ToString();
            }
        }
        private void radChia_CheckedChanged(object sender, EventArgs e)
        {
            if (radChia.Checked)
            {
                double so1, so2;
                if (txtSo1.Text == "" || txtSo2.Text == "")
                {
                    txtKetQua.Text = "Vui lòng nhập đủ 2 số.";
                    return;
                }
                try
                {
                    so1 = Convert.ToDouble(txtSo1.Text);
                    so2 = Convert.ToDouble(txtSo2.Text);
                }
                catch
                {
                    txtKetQua.Text = "Giá trị nhập không hợp lệ.";
                    return;
                }
                if (so2 == 0)
                {
                    txtKetQua.Text = "Không thể chia cho 0.";
                    return;
                }
                double ketQua = so1 / so2;
                txtKetQua.Text = ketQua.ToString();
            }
        }
        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
