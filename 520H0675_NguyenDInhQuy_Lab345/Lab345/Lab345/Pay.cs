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
    public partial class Pay : Form
    {
        public Pay()
        {
            InitializeComponent();
        }

        private void Pay_Load(object sender, EventArgs e)
        {
            labelName.Text = Purchase.name;
            labelPhone.Text = Purchase.phone;
            labelType.Text = Purchase.type;
            labelDenominations.Text = Purchase.deno;
            labelPrice.Text = Purchase.price;
            QRCoder.QRCodeGenerator QR = new QRCoder.QRCodeGenerator();
            var myData = QR.CreateQrCode(labelType.Text,QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(myData);
            pictureCode.Image = code.GetGraphic(50);
        }
    }
}
