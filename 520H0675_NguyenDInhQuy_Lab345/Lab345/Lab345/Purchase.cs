using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Lab345
{
    public partial class Purchase : Form
    {
        public static string name = "";
        public static string phone = "";
        public static string type = "";
        public static string deno = "";
        public static string price = "";

        public Purchase()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start s = new Start();
            s.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhone.Clear();
            cmbType.SelectedIndex = -1;
            cmbDenominations.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            Pay p = new Pay();
            p.ShowDialog();
            
        }

        public static void Code()
        {
            Purchase p = new Purchase();
            MessageBox.Show(p.cmbType.GetItemText(p.cmbType.SelectedItem));
            
        }

        
        private  void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = cmbType.Text.ToString();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            name = txtName.Text.ToString();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            phone = txtPhone.Text.ToString();
        }

        private void cmbDenominations_SelectedIndexChanged(object sender, EventArgs e)
        {
            deno = cmbDenominations.Text.ToString();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            price = txtPrice.Text.ToString();
        }
    }
    
}
