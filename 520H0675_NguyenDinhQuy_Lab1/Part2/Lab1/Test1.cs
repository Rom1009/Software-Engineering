using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Test1 : Form
    {
        public Test1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click Ok to extsit");
            Application.Exit();
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = Color.Red;
        }

        private void txtNhapten_TextChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Text = txtNhapten.Text;
            lblLaptrinh.ForeColor = Color.Red;

        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = Color.Black;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Font = new Font(lblLaptrinh.Font.Name, lblLaptrinh.Font.Size, lblLaptrinh.Font.Style ^ FontStyle.Bold);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Font = new Font(lblLaptrinh.Font.Name, lblLaptrinh.Font.Size, lblLaptrinh.Font.Style ^ FontStyle.Italic);
        }

        private void chkGach_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Font = new Font(lblLaptrinh.Font.Name, lblLaptrinh.Font.Size, lblLaptrinh.Font.Style ^ FontStyle.Underline);
        }
    }
}
