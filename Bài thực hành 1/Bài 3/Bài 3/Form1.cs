using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        private List<int> GetDivisors(int number)
        {
            List<int> divisors = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisors.Add(i);
                }
            }
            return divisors;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSo.Text, out int number) && number > 0)
            {
                cboSo.Items.Add(number);
                txtSo.Clear();
                txtSo.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }
        }
        private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSo.SelectedItem != null)
            {
                int selectedNumber = (int)cboSo.SelectedItem;
                List<int> divisors = GetDivisors(selectedNumber);
                listUoc.Items.Clear();
                foreach (var divisor in divisors)
                {
                    listUoc.Items.Add(divisor);
                }
            }
        }
        private void btnTongcacuocso_Click(object sender, EventArgs e)
        {
            if (listUoc.Items.Count > 0)
            {
                int sum = 0;
                foreach (var item in listUoc.Items)
                {
                    sum += (int)item;
                }
                MessageBox.Show("Tổng các ước số: " + sum);
            }
            else
            {
                MessageBox.Show("Chưa chọn số nào.");
            }
        }
        private void btnSoluongcacuocsochan_Click(object sender, EventArgs e)
        {
            if (listUoc.Items.Count > 0)
            {
                int demsochan = 0;
                foreach (var item in listUoc.Items)
                {
                    if ((int)item % 2 == 0)
                    {
                        demsochan++;
                    }
                }
                MessageBox.Show("Số lượng ước số chẵn: " + demsochan);
            }
            else
            {
                MessageBox.Show("Chưa chọn số nào.");
            }
        }
        private void btnSoluongcacuocsonguyen_Click(object sender, EventArgs e)
        {
            if (listUoc.Items.Count > 0)
            {
                int demsonguyen = 0;
                foreach (var item in listUoc.Items)
                {
                    if (IsPrime((int)item))
                    {
                        demsonguyen++;
                    }
                }
                MessageBox.Show("Số lượng ước số nguyên tố: " + demsonguyen);
            }
            else
            {
                MessageBox.Show("Chưa chọn số nào.");
            }
        }
        private void txtSo_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void listUoc_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cboSo.Items.Clear();
            listUoc.Items.Clear();
        }
    }
}
