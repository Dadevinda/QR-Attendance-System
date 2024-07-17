using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_System__
{
 
    public partial class Form2 : Form
    {

        public static string a;
        public static string b;
       
       Class1 ca = new Class1();
       
        public Form2()
        {
            InitializeComponent();

            pictureBox2.Visible= false;
            pictureBox3.Visible=false;
            pictureBox4.Visible=false;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label6.Visible = false;
               
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                label7.Visible = false;
                pictureBox1.Location = pictureBox4.Location;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {



            //optimised

            string c = "select * from Login where UserName='" + textBox1.Text + "' and Pass='" + textBox2.Text + "'";
            string check =ca.check(c);
            if(check == "yes")
            {
                //get user post
                string post = "select post from A_Register where UserName='" + textBox1.Text + "'";
                a = ca.data(post);

                // get user name
                string name = "select F_Name from A_Register where UserName='" + textBox1.Text + "'";
                b= ca.data(name);
                Form7 hii = new Form7();
                hii.Show();
                Hide();
            }
            if(check == "no")
            {
                label6.Visible = true;
                label7.Visible = true;


                //log in button
                if (pictureBox1.Location == pictureBox4.Location)
                {
                    pictureBox1.Location = pictureBox2.Location;
                }
                else if (pictureBox1.Location == pictureBox2.Location)
                {
                    pictureBox1.Location = pictureBox3.Location;
                }
                else if (pictureBox1.Location == pictureBox3.Location)
                {
                    pictureBox1.Location = pictureBox4.Location;
                }
            }

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==false)
            {
                textBox2.UseSystemPasswordChar= false;
            }
            else if(checkBox1.Checked==true) 
            {
              textBox2.UseSystemPasswordChar= true;
             
            }
        }
    }
}
