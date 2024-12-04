using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bài_1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private int i = 20;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i > 0)
            {
                lblDongHo.Text = i.ToString();
                i--;
            }
            else
            {
                timer1.Stop();
                lblDongHo.Text = "Hết giờ!";
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            i = 20;
            lblDongHo.Text = i.ToString(); 
            timer1.Start();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void lblDongHo_Click(object sender, EventArgs e)
        {
            
        }
    }
}
