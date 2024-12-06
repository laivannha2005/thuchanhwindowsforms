using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode nodeKhoaCntt = new TreeNode(" Công Nghệ Thông Tin");
            // Thêm các lớp vào TreeView
            TreeNode nodeSV1 = new TreeNode("12523W.1");
            TreeNode nodeSV2 = new TreeNode("12523W.2");
            TreeNode nodeSV3 = new TreeNode("12523W.3");
            // Thêm sinh viên vào từng lớp
            nodeSV1.Nodes.Add("Nguyễn Đức Toàn");
            nodeSV1.Nodes.Add("Đỗ Đình Quân");
            nodeSV2.Nodes.Add("Lại Văn Nhã");
            nodeSV2.Nodes.Add("Nguyễn Xuân Nghiệp");
            nodeSV3.Nodes.Add("Lưu Văn Đức Anh");
            nodeSV3.Nodes.Add("Nguyễn Minh Vương");
            // Thêm các lớp vào TreeView
            treeView1.Nodes.Add(nodeKhoaCntt);
            treeView1.Nodes.Add(nodeSV1);
            treeView1.Nodes.Add(nodeSV2);
            treeView1.Nodes.Add(nodeSV3);
            // Đặt con trỏ tại ô Nhập tên
            txtNhapten.Focus();
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();
            // Kiểm tra nếu node được chọn là lớp học
            if (e.Node.Level == 0)
            {
                // Thêm toàn bộ sinh viên thuộc lớp được chọn vào ListView
                foreach (TreeNode studentNode in e.Node.Nodes)
                {
                    listView1.Items.Add(new ListViewItem(new[] { studentNode.Text, e.Node.Text }));
                }
            }
            // Nếu node được chọn là sinh viên
            else if (e.Node.Level == 1)
            {
                listView1.Items.Add(new ListViewItem(new[] { e.Node.Text, e.Node.Parent.Text }));
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            string searchText = txtNhapten.Text.Trim();
            listView1.Items.Clear();
            foreach (TreeNode classNode in treeView1.Nodes)
            {
                foreach (TreeNode studentNode in classNode.Nodes)
                {
                    if (studentNode.Text.ToLower().Contains(searchText.ToLower()))
                    {
                        listView1.Items.Add(new ListViewItem(new[] { studentNode.Text, classNode.Text }));
                    }
                }
            }
        }
        private void btnCapkhoa_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            // Thêm toàn bộ sinh viên từ TreeView vào ListView
            foreach (TreeNode classNode in treeView1.Nodes)
            {
                foreach (TreeNode studentNode in classNode.Nodes)
                {
                    listView1.Items.Add(new ListViewItem(new[] { studentNode.Text, classNode.Text }));
                }
            }
        }

    }
}

