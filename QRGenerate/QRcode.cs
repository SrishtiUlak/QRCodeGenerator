using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeGenerator
{
    public partial class QRcode : Form
    {
        public QRcode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var data = QG.CreateQrCode(textBox1.Text,QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(data);
            pictureBox1.Image = code.GetGraphic(50);
        }
    }
}
