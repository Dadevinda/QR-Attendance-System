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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            string c = Form2.a;
            if (c == "Member")
            {
                pictureBox2.Visible= false;
                pictureBox4.Visible= false;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;

                pictureBox7.Parent = pictureBox1;
                pictureBox7.BackColor = Color.Transparent;

                pictureBox8.Parent = pictureBox1;
                pictureBox8.BackColor = Color.Transparent;
            }
            else
            {
                pictureBox2.Visible = true;
                pictureBox4.Visible = true;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
            }


            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;

            pictureBox3.Parent = pictureBox1;
            pictureBox3.BackColor = Color.Transparent;

            pictureBox4.Parent = pictureBox1;
            pictureBox4.BackColor = Color.Transparent;

            pictureBox5.Parent = pictureBox1;
            pictureBox5.BackColor = Color.Transparent;

            pictureBox6.Parent = pictureBox1;
            pictureBox6.BackColor = Color.Transparent;

           
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor= Color.White;
           
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.White;
            
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.White;
           
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.White;
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form2 hii = new Form2();
            hii.Show();
            Hide();
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.White;
            
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
         
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Transparent;
            
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
           
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
           
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form14 hii = new Form14();
            hii.Show();
            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 HII = new Form1();
            HII.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form10 hi = new Form10();
            hi.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form15 hii = new Form15();
            hii.Show();
            Hide();
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
    
}
