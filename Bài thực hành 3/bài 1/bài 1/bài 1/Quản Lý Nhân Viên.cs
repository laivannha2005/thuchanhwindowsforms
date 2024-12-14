using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace bài_1
{
    public partial class Quản_Lý_Nhân_Viên : Form
    {
        public Quản_Lý_Nhân_Viên()
        {
            InitializeComponent();
        }
        private void Quản_Lý_Nhân_Viên_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            string manhanvien = txtmanhanvien.Text;
            string tennhanvien = txtnhanvien.Text;
            string diachi = txtdiachi.Text;
            string tendangnhap = txttendangnhap.Text;
            string quyenhan = "";
            if (cboquyenhan.SelectedItem != null)
            {
                quyenhan = cboquyenhan.SelectedItem.ToString();
            }
            if (manhanvien == "" || tennhanvien == "" || diachi == "" || tendangnhap == "" || quyenhan == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] row = new string[]
                {
                    manhanvien,
                    tennhanvien,
                    diachi,
                    tendangnhap,
                    quyenhan
                };
                dataGridView1.Rows.Add(row);
                txtmanhanvien.Clear();
                txtnhanvien.Clear();
                txtdiachi.Clear();
                txttendangnhap.Clear();
                cboquyenhan.SelectedIndex = -1;
                txtmanhanvien.Focus();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtnhanvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có chắc muốn thoát không ?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnSuanv_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index != -1)
            {
                try
                {
                    int a = dataGridView1.CurrentRow.Index;
                    string manhanvien = txtmanhanvien.Text;
                    string tenhanvien = txtnhanvien.Text;
                    string diachi = txtdiachi.Text;
                    string tendangnhap = txttendangnhap.Text;
                    string quyenhan = "";
                    if (cboquyenhan.SelectedItem != null)
                    {
                        quyenhan = cboquyenhan.SelectedItem.ToString();
                    }
                    if (manhanvien == "" || tenhanvien == "" || diachi == "" || tendangnhap == "" || quyenhan == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dataGridView1.Rows[a].Cells[0].Value = manhanvien;
                    dataGridView1.Rows[a].Cells[1].Value = tenhanvien;
                    dataGridView1.Rows[a].Cells[2].Value = diachi;
                    dataGridView1.Rows[a].Cells[3].Value = tendangnhap;
                    dataGridView1.Rows[a].Cells[4].Value = quyenhan;
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa trong bảng!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnXoanv_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index != -1)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        int rowIndex = dataGridView1.CurrentRow.Index;
                        dataGridView1.Rows.RemoveAt(rowIndex);
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra khi xóa nhân viên: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
