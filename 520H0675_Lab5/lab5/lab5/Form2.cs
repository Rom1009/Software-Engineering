using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Dependent", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    comboBoxDependent.DataSource = dt;
                    comboBoxDependent.DisplayMember = "Dependent_Name";
                    comboBoxDependent.ValueMember = "ESSN";
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Warnning");
                }
                adapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + " - " + ex.Source);
            }
        }

        private void LoadData()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE SSN=@CB", conn);
                cmd.Parameters.AddWithValue("@CB", comboBoxDependent.SelectedValue.ToString());

               
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewEmployee.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Warning");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + " - " + ex.Source);
            }
        }

        private void comboBoxDependent_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
