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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "https://vnexpress.net");
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click Ok to exist");
            Application.Exit();
        }

        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {
            if (txtEmployeeName.Text == "")
            {
                MessageBox.Show("Employee Name should not be empty", "Warning Box");
                this.ActiveControl = txtEmployeeName;
            }
        }

        private void mskDoT_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mskDoT.MaskCompleted != true)
            {
                MessageBox.Show("Employee's DoB should not be empty", "Warning Box");
                this.ActiveControl = mskDoT;
                mskDoT.Select(0, 0);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Employee Address should not be empty", "Warning Box");
                this.ActiveControl = txtAddress;
            }
        }

        private void listCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            String temp = listCity.Text;
            if (temp == "")
            {
                MessageBox.Show("Can not leave City empty", "Warning Box");
                this.ActiveControl = listCity;
            }
        }

        private void comboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            String temp = comboCountry.Text;
            if (temp == "")
            {
                MessageBox.Show("Can not leave Country empty", "Warning Box");
                this.ActiveControl = comboCountry;
            }
        }

        private void listQualify_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listQualify.Text == "")
            {
                MessageBox.Show("Can not leave Qualification Empty", "Warning Box");
                this.ActiveControl = listQualify;
            }
        }

        private void mskPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mskPhone.MaskCompleted != true)
            {
                MessageBox.Show("Can not leave Phone Number empty", "Warning Box");
                this.ActiveControl = mskPhone;
                mskPhone.Select(0, 0);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Can not leave Email Empty", "Warning Box");
                this.ActiveControl = txtEmail;
            }
            else
            {
                if (txtEmail.Text.Contains("@") == false)
                {
                    MessageBox.Show("There must be @ in email", "Missing character in Email");
                    this.ActiveControl = txtEmail;
                }
            }
        }

        private void dot_ValueChanged(object sender, EventArgs e)
        {
            if(dot.Checked != true)
            {
                MessageBox.Show("Should change");
                this.ActiveControl = txtEmail;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String name = txtEmployeeName.Text.ToString();
            String dob = mskDoT.Text.ToString();
            String address = txtAddress.Text.ToString();
            String city = listCity.Text.ToString();
            String country = comboCountry.Text.ToString();
            String qualification = listQualify.Text.ToString();
            String phone = mskPhone.Text.ToString();
            String email = txtEmail.Text.ToString();
            String date = dot.Text.ToString();

            String temp = name + "\n" + dob + "\n" + address + "\n" + city + "\n" + country + "\n" + qualification + "\n" + phone + "\n" + email + "\n" + date + "";
            MessageBox.Show(temp, "Information Box");
        }
    }
}
