using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 65; i <= 90; i++)  // Duyệt qua các chữ cái từ A đến Z
            {
                string kt = ((char)i).ToString();   // Chuyển từ số về ký tự và sang chuỗi 
                treeView1.Nodes.Add(kt, kt);   // Thêm node vào TreeView  
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Biết chắc chắn, key của Node là ký tự đầu tiên của tên 
            String key = txtFirst.Text.Trim()[0].ToString();

            if (treeView1.Nodes.ContainsKey(key))
            {
                treeView1.Nodes[key].Nodes.Add(txtFirst.Text + ", " + txtLast.Text);
            }
            else
            {
                MessageBox.Show("Node không tồn tại.");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Thoát ứng dụng
            Application.Exit();
        }
    }
}

