using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8
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
            TreeNode node1 = new TreeNode("NCTH3KA");
            TreeNode node2 = new TreeNode("NCTH3KB");
            TreeNode node3 = new TreeNode("CDTH11K");
            treeView1.Nodes.Add(node1);
            treeView1.Nodes.Add(node2);
            treeView1.Nodes.Add(node3);
            // Đặt con trỏ tại ô Nhập tên
            txtHoTen.Focus();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null || treeView1.SelectedNode.Parent != null)
            {
                MessageBox.Show("Vui lòng chọn một lớp để thêm sinh viên.");
                return;
            }
            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            // Kiểm tra thông tin nhập
            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            // Kiểm tra trùng mã SV
            foreach (TreeNode node in treeView1.SelectedNode.Nodes)
            {
                if (node.Text.StartsWith(maSV + "-"))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại.");
                    return;
                }
            }
            // Thêm sinh viên vào lớp
            TreeNode svNode = new TreeNode($"{maSV}-{hoTen}")
            {
                Tag = diaChi // Gắn địa chỉ vào Tag
            };
            treeView1.SelectedNode.Nodes.Add(svNode);
            treeView1.SelectedNode.Expand();
            // Xóa dữ liệu nhập sau khi thêm
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null || treeView1.SelectedNode.Parent == null)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa.");
                return;
            }
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent != null) // Chỉ áp dụng cho nút sinh viên
            {
                string[] details = e.Node.Text.Split('-');
                txtMaSV.Text = details[0];
                txtHoTen.Text = details[1];
                txtDiaChi.Text = e.Node.Tag?.ToString() ?? string.Empty;
            }
            else
            {
                txtMaSV.Clear();
                txtHoTen.Clear();
                txtDiaChi.Clear();
            }
        }
    }
}
