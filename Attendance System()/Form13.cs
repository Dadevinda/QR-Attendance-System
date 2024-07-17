using MessagingToolkit.QRCode.Codec;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Attendance_System__
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            { 
           QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(textBox1.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pictureBox1.Image = code.GetGraphic(7);
           
            }


        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                string v = textBox1.Text;
                SaveFileDialog sf = new SaveFileDialog();
                sf.FileName = v;
                sf.Filter = "PNG Image only(*.png)|*.png";
                sf.AddExtension = true;


                if (sf.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(sf.FileName, System.Drawing.Imaging.ImageFormat.Png);

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form14 hii = new Form14();
            hii.Show();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                pictureBox1.Image = null;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
