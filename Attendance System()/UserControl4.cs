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
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
            userControl101.Visible = false;
            userControl111.Visible = false;
            userControl81.Visible= false;
            userControl91.Visible= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl101.Visible = false;
            userControl111.Visible = false;
            userControl81.Visible = true;
            userControl91.Visible = false;
            userControl81.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl101.Visible = false;
            userControl111.Visible = false;
            userControl81.Visible = false;
            userControl91.Visible = true;
            userControl91.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl101.Visible = true;
            userControl111.Visible = false;
            userControl81.Visible = false;
            userControl91.Visible = false;
            userControl101.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl101.Visible = false;
            userControl111.Visible = true;
            userControl81.Visible = false;
            userControl91.Visible = false;
            userControl111.BringToFront();
        }

        private void userControl111_Load(object sender, EventArgs e)
        {

        }
    }
}
