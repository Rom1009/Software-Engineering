using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab345
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuyTicket bt = new BuyTicket();
            bt.ShowDialog();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            Exist exist = new Exist();
            exist.ShowDialog();
        }
    }
}
