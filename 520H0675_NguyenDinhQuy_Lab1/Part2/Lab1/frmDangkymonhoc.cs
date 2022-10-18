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
    public partial class frmDangkymonhoc : Form
    {
        public frmDangkymonhoc()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click OK to Leave", "Exit Message Box");
            Application.Exit();
        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {
            if (txtMSSV.Text == "")
            {
                MessageBox.Show("Can not leave MSSV empty", "Warning Box");
                this.ActiveControl = txtMSSV;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Can not leave Fullname empty", "Warning Box");
                this.ActiveControl = txtName;
            }
        }

        private void cbnlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbnlop.Text == "")
            {
                MessageBox.Show("Please Choose Your Class ID", "Warning Box");
                this.ActiveControl = cbnlop;
            }
        }

        private void btbSignin_Click(object sender, EventArgs e)
        {
            String s1 = "";
            bool radioToken = false;
            List<RadioButton> rdlist = new List<RadioButton>();
            rdlist.Add(rdn1);
            rdlist.Add(rdn2);
            rdlist.Add(rdn3);
            rdlist.Add(rdn4);
            foreach (RadioButton rd in rdlist)
            {
                if (rd.Checked == true)
                {
                    s1 = rd.Text;
                    radioToken = true;
                    break;
                }
            }
            if (radioToken == false)
            {
                MessageBox.Show("Choose a Semester", "Warning Box");
            }

            string s = "";
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please Choose a Subject", "Warning Box");
            }
            else
            {
                for (int x = 0; x < checkedListBox1.CheckedItems.Count; x++)
                {
                    s = s + "\tChecked Item " + (x + 1).ToString() + " = " + checkedListBox1.CheckedItems[x].ToString() + "\n";
                }
            }

            String returnResult = "Sinh viên: " + txtName.Text + "\nMSSV: " + txtMSSV.Text + "\nYear: " + cmbyear.Text 
                + "\nSemester: " + s1 
                + "\nTotal Subjects:\n" + s + "";
            MessageBox.Show(returnResult);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtMSSV.Clear();
            txtName.Text = String.Empty;

            cmbyear.Items.Clear();
            cbnlop.Items.Clear();

            rdn1.Checked = false;
            rdn2.Checked = false;
            rdn3.Checked = false;
            rdn4.Checked = false;

            cmbyear.Items.Clear();
            cbnlop.Items.Clear();

            for (int x = 0; x < checkedListBox1.Items.Count; x++)
            {

                checkedListBox1.SetItemChecked(x, false);
            }
        }
    }
}
