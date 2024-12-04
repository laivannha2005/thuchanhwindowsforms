using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_5
{
    public partial class groupBox2 : Form
    {
        public groupBox2()
        {
            InitializeComponent();
        }

        private void txtNhapten_TextChanged(object sender, EventArgs e)
        {
            txtLaptrinhboi.Text = txtNhapten.Text;
        }
        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if(radRed.Checked == true)
            {
                txtLaptrinhboi.ForeColor = Color.Red;
            }
        }
        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if(radGreen.Checked == true)
            {
                txtLaptrinhboi.ForeColor = Color.Green;
            }
        }
        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if(radBlue.Checked == true)
            {
                txtLaptrinhboi.ForeColor = Color.Blue;
            }
        }
        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if(radBlack.Checked == true)
            {
                txtLaptrinhboi.ForeColor = Color.Black;
            }
        }
        private void chkDamBold_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDamBold.Checked == true)
            {
                txtLaptrinhboi.Font = new Font(txtLaptrinhboi.Font, FontStyle.Bold);
            }
            else
            {
                txtLaptrinhboi.Font = new Font(txtLaptrinhboi.Font, FontStyle.Regular);
            }
        }
        private void chkNghiengItalic_CheckedChanged(object sender, EventArgs e)
        {
            if(chkNghiengItalic.Checked == true)
            {
                txtLaptrinhboi.Font = new Font(txtLaptrinhboi.Font, FontStyle.Italic);
            }
            else
            {
                txtLaptrinhboi.Font = new Font(txtLaptrinhboi.Font, FontStyle.Regular);
            }
        }

        private void chkGachChan_CheckedChanged(object sender, EventArgs e)
        {
            if(chkGachChan.Checked == true)
            {
                txtLaptrinhboi.Font = new Font(txtLaptrinhboi.Font, FontStyle.Underline);
            }
            else
            {
                txtLaptrinhboi.Font = new Font(txtLaptrinhboi.Font, FontStyle.Regular);
            }
        }
        private void txtLaptrinhboi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
