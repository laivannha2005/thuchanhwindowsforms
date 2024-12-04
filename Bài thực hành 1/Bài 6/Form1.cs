using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radtime_CheckedChanged(object sender, EventArgs e)
        {
            if (radtime.Checked)
            {
                textBox1.Font = new Font("Times New Roman", textBox1.Font.Size);
            }
        }

        private void radArial_CheckedChanged(object sender, EventArgs e)
        {
            if (radArial.Checked)
            {
                textBox1.Font = new Font("Arial", textBox1.Font.Size);
            }
        }

        private void radTahoma_CheckedChanged(object sender, EventArgs e)
        {
            if (radTahoma.Checked)
            {
                textBox1.Font = new Font("Tahoma", textBox1.Font.Size);
            }
        }

        private void radCourier_CheckedChanged(object sender, EventArgs e)
        {
            if (radCourier.Checked)
            {
                textBox1.Font = new Font("Courier New", textBox1.Font.Size);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
