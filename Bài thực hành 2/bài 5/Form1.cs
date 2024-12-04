using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bài_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            for (int i = 65; i <= 90; i++)
            {
                string kt = ((char)i).ToString(); 
                treeView1.Nodes.Add(kt, kt); 
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string key = txtFirstName.Text.Trim()[0].ToString();
            if (treeView1.Nodes.ContainsKey(key))
            {

                treeView1.Nodes[key].Nodes.Add(txtFirstName.Text + ", " + txtLastName.Text);
            }
            else
            {
                MessageBox.Show("Không tìm thấy chữ cái đầu tiên của tên trong danh sách A-Z.");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 65; i <= 90; i++) 
            {
                string letter = ((char)i).ToString(); 
                treeView1.Nodes.Add(letter, letter); 
            }
        }
    }


}
