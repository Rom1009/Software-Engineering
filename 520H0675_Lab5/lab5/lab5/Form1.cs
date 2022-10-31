﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace lab5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();

                String sSQL = "SELECT * FROM Department";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    comboBoxDepartment.DataSource = dt;
                    comboBoxDepartment.DisplayMember = "DName";
                    comboBoxDepartment.ValueMember = "DNumber";
                    LoadData();
                }
                else
                {
                    MessageBox.Show("No Data", "Warnning");
                }
                adapter.Dispose();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message + " - " + ex.Source);
            }
        }

        private void LoadData()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();

                String sSQL = "SELECT * FROM Employee WHERE DNo=@CB";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@CB", comboBoxDepartment.SelectedValue.ToString());

                //String sSQL = "SELECT * FROM Employee where DNo=" + comboBoxDepartment.SelectedValue;
                //SqlCommand cmd = new SqlCommand(sSQL, conn);


                //SqlCommand cmd = new SqlCommand("SELECT * FROM Employee where DNo=" + comboBoxDepartment.SelectedValue, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data", "Warning");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message + " - " + ex.Source);
            }
        }

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
