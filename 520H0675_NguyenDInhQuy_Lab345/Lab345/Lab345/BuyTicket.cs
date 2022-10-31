using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab345
{
    public partial class BuyTicket : Form
    {
        public BuyTicket()
        {
            InitializeComponent();
        }


        private void BuyTicket_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();
                String sSQL = "select * from Location";
                SqlCommand cmd = new SqlCommand(sSQL, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewBuyTicket.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data", "Warning No Data");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start st = new Start();
            st.ShowDialog();
        }

        private void dataGridViewBuyTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewBuyTicket.SelectedCells[0].RowIndex;
            if (index < 0 || index >= dataGridViewBuyTicket.Rows.Count)
            {
                return;
            }

            DataGridViewRow row = dataGridViewBuyTicket.Rows[index];
            String destination = row.Cells[0].Value.ToString().Trim();
            int Price = int.Parse(row.Cells[1].Value.ToString().Trim());
            String startDate = row.Cells[2].Value.ToString().Trim();
            String endDate = row.Cells[3].Value.ToString().Trim();
            int availability = int.Parse(row.Cells[4].Value.ToString().Trim());
            int amount = int.Parse(row.Cells[5].Value.ToString().Trim());


            txtDest.Text = destination;
            txtPrice.Text = Price.ToString();
            startDatetime.Text = startDate;
            endDatetime.Text = endDate;
            txtAvailable.Text = availability.ToString();
            numAmount.Text = amount.ToString();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            int index = dataGridViewBuyTicket.SelectedCells[0].RowIndex;
            if (index < 0 || index >= dataGridViewBuyTicket.Rows.Count)
            {
                return;
            }

            DataGridViewRow row = dataGridViewBuyTicket.Rows[index];
            int amount = int.Parse(row.Cells[5].Value.ToString().Trim());
            if (amount > 0)
            {
                Purchase ps = new Purchase();
                ps.ShowDialog();
            }
            else
            {
                MessageBox.Show("Currently, tickets are no longer for sale");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDest.Clear();
            txtPrice.Clear();
            DateTime startDatetime = DateTime.MinValue;
            DateTime endDatetime = DateTime.MinValue;
            txtAvailable.Clear();
            numAmount.ResetText();
        }
    }
}
