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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            button1.Enabled= false;
        }
        Class1 ca = new Class1();
        public void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            checkBox1.Checked = false;
            
        }
        public void t1()
        {
            if (textBox1.Text == "")
            {
                label3.Visible = false;
                label4.Visible = true;
            }
            else
            {
                label3.ForeColor = Color.Black;
                label3.Visible = true;
                label4.Visible = false;
                textBox1.Text = textBox1.Text;
            }
        }
        public void t2()
        {
            if (textBox2.Text == "")
            {
                label5.Visible = false;
                label6.Visible = true;
            }
            else
            {
                label5.ForeColor = Color.Black;
                label5.Visible = true;
                label6.Visible = false;
                textBox2.Text = textBox2.Text;
            }
        }
        public void t3()
        {
            if (textBox3.Text == "")
            {
                label8.Visible = false;
                label7.Visible = true;
            }
            else
            {

                label8.ForeColor = Color.Black;
                label8.Visible = true;
                label7.Visible = false;

            }
        }
        public void t4()
        {
            if (textBox4.Text == "")
            {
                label11.Visible = false;
                label10.Visible = true;
            }
            else
            {
                label11.ForeColor = Color.Black;
                label11.Visible = true;
                label10.Visible = false;
                textBox4.Text = textBox4.Text;
            }
        }
        public void t5()
        {
            if (textBox5.Text == "")
            {
                label12.Visible = false;
                label13.Visible = true;
            }
            else
            {
                label12.ForeColor = Color.Black;
                label12.Visible = true;
                label13.Visible = false;
                textBox5.Text = textBox5.Text;
            }
        }
        public void t7()
        {
            if (textBox7.Text == "")
            {
                label15.Visible = false;
                label17.Visible = true;
            }
            else
            {
                label15.ForeColor = Color.Black;
                label15.Visible = true;
                label17.Visible = false;
                textBox7.Text = textBox7.Text;
            }
        }
        public void t8()
        {
            if (textBox8.Text == "")
            {
                label16.Visible = false;
                label18.Visible = true;
            }
            else
            {
                label16.ForeColor = Color.Black;
                label16.Visible = true;
                label18.Visible = false;
                textBox8.Text = textBox8.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                if (textBox1.Text == "")
                {
                    label27.Visible = true;
                }


                if (textBox2.Text == "")
                {
                    label28.Visible = true;
                }


                if (textBox3.Text == "")
                {
                    label29.Visible = true;
                }

                if (textBox7.Text == "")
                {
                    label30.Visible = true;
                }
                if (textBox5.Text == "")
                {
                    label31.Visible = true;
                }

                if (textBox8.Text == "")
                {
                    label26.Visible = true;
                }
                if (textBox4.Text == "")
                {
                    label14.Visible = true;
                }

            }
            else
            {
             
                
                string id = textBox6.Text;
                string first = textBox1.Text;
                string last = textBox2.Text;
                string mail = textBox3.Text + "@gmail.com";
                string subject = textBox4.Text;
                string age = textBox5.Text;
                string address = textBox7.Text;
                string phone = textBox8.Text;
                string query = "insert into Lecturer (Lecturer_Id,F_Name,L_Name,Mail,Subject,Age,Address,Phone_No)values" + "('"+id+ "','"+first+"','"+last+"','"+mail +"','"+subject +"','" + age + "','"+address+"','" + phone+"')";
                ca.insert(query);
                clear();
                string idquery = "select count(Lecturer_Id) from Lecturer";
                textBox6.Text = ca.id(idquery);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 hii = new Form10();
            hii.Show();
            Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                label31.Visible = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                label14.Visible = false;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            if (textBox7.Text != "")
            {
                label30.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label27.Visible = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                label29.Visible = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                label28.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Focus();
            if (checkBox1.Checked == false)
            {
                button1.Enabled = false;
            }
            if (checkBox1.Checked == true)
            {
                button1.Enabled = true;
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            label16.Visible = true;
            label18.Visible = false;
            label16.ForeColor = Color.DodgerBlue;
            textBox8.Focus();
            t1();
            t2();
            t3();
            t4();
            t5();
            t7();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            label15.Visible = true;
            label17.Visible = false;
            label15.ForeColor = Color.DodgerBlue;
            textBox7.Focus();
            t1();
            t2();
            t3();
            t4();
            t5();
            t8();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            label13.Visible = false;
            label12.Visible = true;
            label12.ForeColor = Color.DodgerBlue;
            textBox5.Focus();
            t1();
            t2();
            t3();
            t4();
            t7();
            t8();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            textBox4.Focus();
            label11.Visible = true;
            label10.Visible = false;
            label11.ForeColor = Color.DodgerBlue;
            t1();
            t2();
            t3();
            t5();
            t7();
            t8();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            label7.Visible = false;
            label8.ForeColor = Color.DodgerBlue;
            textBox3.Focus();
            t2();
            t1();
            t4();
            t5();
            t7();
            t8();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            textBox2.Focus();
            label5.Visible = true;
            label6.Visible = false;
            label5.ForeColor = Color.DodgerBlue;
            t1();
            t3();
            t4();
            t5();
            t7();
            t8();
        }

        private void label4_Click(object sender, EventArgs e)
        {

            label3.Visible = true;
            label4.Visible = false;
            label3.ForeColor = Color.DodgerBlue;
            textBox1.Focus();
            t2();
            t3();
            t4();
            t5();
            t7();
            t8();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {

            label3.Visible = true;
            label4.Visible = false;
            label3.ForeColor = Color.DodgerBlue;
            textBox1.Focus();

            t2();
            t3();
            t4();
            t5();
            t7();
            t8();
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Focus();
            label5.Visible = true;
            label6.Visible = false;
            label5.ForeColor = Color.DodgerBlue;

            t1();
            t3();
            t4();
            t5();
            t7();
            t8();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

            string idquery = "select count(Lecturer_Id) from Lecturer";
            textBox6.Text = ca.id(idquery);

            label19.Parent = pictureBox1;
            label19.BackColor = Color.Transparent;

            label20.Parent = pictureBox1;
            label20.BackColor = Color.Transparent;

            label1.Parent= pictureBox1;
            label1.BackColor = Color.Transparent;

            label3.Visible = true;
            label4.Visible = false;
            label3.ForeColor = Color.DodgerBlue;
            textBox1.Focus();
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            label8.Visible = true;
            label7.Visible = false;
            label8.ForeColor = Color.DodgerBlue;
            textBox3.Focus();
            t2();
            t1();
            t4();
            t5();
            t7();
            t8();
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            label11.Visible = true;
            label10.Visible = false;
            label11.ForeColor = Color.DodgerBlue;
            t1();
            t2();
            t3();
            t5();
            t7();
            t8();
            textBox4.Focus();
        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            label13.Visible = false;
            label12.Visible = true;
            label12.ForeColor = Color.DodgerBlue;
            textBox5.Focus();
            t1();
            t2();
            t3();
            t4();
            t7();
            t8();
        }

        private void textBox7_MouseClick(object sender, MouseEventArgs e)
        {
            label15.Visible = true;
            label17.Visible = false;
            label15.ForeColor = Color.DodgerBlue;
            textBox7.Focus();
            t1();
            t2();
            t3();
            t4();
            t5();
            t8();
        }

        private void textBox8_MouseClick(object sender, MouseEventArgs e)
        {
            label16.Visible = true;
            label18.Visible = false;
            label16.ForeColor = Color.DodgerBlue;
            textBox8.Focus();
            t1();
            t2();
            t3();
            t4();
            t5();
            t7();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
            {
                label26.Visible = false;

                if (textBox8.Text.Length != 10)
                {
                    label21.Visible = true; 
                }
                else
                {
                    label21.Visible = false;
                }
            }
            if (textBox8.Text == "")
            {
                label21.Visible = false;
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void userControl91_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
