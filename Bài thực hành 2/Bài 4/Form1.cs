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

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtMaSV.Text, txtHoTen.Text, txtQueQuan.Text);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtMaSV.Text, txtHoTen.Text, txtQueQuan.Text); 
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtQueQuan.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;  
            if (rowIndex >= 0)  
            {
                txtMaSV.Text = dataGridView1.Rows[rowIndex].Cells["MaSV"].Value.ToString();
                txtHoTen.Text = dataGridView1.Rows[rowIndex].Cells["HoTen"].Value.ToString();
                txtQueQuan.Text = dataGridView1.Rows[rowIndex].Cells["QueQuan"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MaSV"].Value.ToString() == maSV)
                {
                    row.Cells["HoTen"].Value = txtHoTen.Text;
                    row.Cells["QueQuan"].Value = txtQueQuan.Text;
                    break; 
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["MaSV"].Value.ToString() == maSV)
                {
                    dataGridView1.Rows.RemoveAt(i);
                    break; 
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
    for (int i = 0; i < dataGridView1.Rows.Count; i++)
    {
        if (dataGridView1.Rows[i].Cells["MaSV"].Value.ToString() == maSV)
        {
            dataGridView1.Rows[i].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];  // Đưa con trỏ đến dòng tìm thấy
            break;
        }
    }
        }

        private void btnketthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
