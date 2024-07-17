using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_System__
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form13 hii = new Form13();
            hii.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form6 hii= new Form6();
            hii.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 hii = new Form7();
            hii.Show();
            Hide();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }
    }
}
