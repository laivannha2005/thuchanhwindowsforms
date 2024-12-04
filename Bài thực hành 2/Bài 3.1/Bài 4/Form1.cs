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
        private List<SinhVien> sinhViens = new List<SinhVien>();
        public Form1()
        {
            InitializeComponent();
            listView1.FullRowSelect = true;
            listView1.SmallImageList = ilsminion;
            listView1.View = View.Details;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaSv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLop_TextChanged(object sender, EventArgs e)
        {

        }
        private void CapNhatListView()
        {
            listView1.Items.Clear();
            foreach (var sinhVien in sinhViens)
            {
                ListViewItem item = new ListViewItem(sinhVien.MaSv);
                item.SubItems.Add(sinhVien.HoTen);
                item.SubItems.Add(sinhVien.DiaChi);
                item.SubItems.Add(sinhVien.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(sinhVien.Lop);
                listView1.Items.Add(item);
                item.ImageIndex = 0;
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string maSv = txtMaSv.Text;
            string hoTen = txtHoTen.Text;
            string diaChi = txtDiaChi.Text;
            DateTime ngaySinh = dateTimeNgaySinh.Value;
            string lop = lstLop.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(maSv) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(lop))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            SinhVien sinhVien = new SinhVien(maSv, hoTen, diaChi, ngaySinh, lop);
            sinhViens.Add(sinhVien);
            MessageBox.Show("Thêm mới thành công!");
        }
        private void btnCapNhatItem_Click(object sender, EventArgs e)
        {
            CapNhatListView();
            MessageBox.Show("Cập nhật danh sách thành công!");
        }

        private void btnXoaItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string maSv = listView1.SelectedItems[0].SubItems[0].Text;
                var sinhVienToXoa = sinhViens.Find(sv => sv.MaSv == maSv);
                if (sinhVienToXoa != null)
                {
                    sinhViens.Remove(sinhVienToXoa);
                    CapNhatListView();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa.");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void ChangeViewMode(View viewMode) 
        {
            listView1.View = viewMode;
        }
        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeViewMode(View.SmallIcon);
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeViewMode(View.List);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ltbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void dateTimeNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    public class SinhVien
    {
        public string MaSv { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Lop { get; set; }

        public SinhVien(string maSv, string hoTen, string diaChi, DateTime ngaySinh, string lop)
        {
            MaSv = maSv;
            HoTen = hoTen;
            DiaChi = diaChi;
            NgaySinh = ngaySinh;
            Lop = lop;
        }
    }
}
