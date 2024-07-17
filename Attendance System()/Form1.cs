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

    public partial class Form1 : Form
    {
        public static string g;
        //Form2 hii = new Form2();
        
        public Form1()
        {
            InitializeComponent();
            userControl11.Visible = false;
            userControl21.Visible = false;
            userControl31.Visible = false;
            userControl63.Visible = false;
            timer1.Start();
          
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
           

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label6_DoubleClick(object sender, EventArgs e)
        {
           
           
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void label6_Leave(object sender, EventArgs e)
        {

        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl21.Visible = true ;
            userControl63.Visible = false;
            userControl31.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            userControl61.Visible = false;

            string c = Form2.a;
            if (c == "Member")
            { 
                button6.Enabled= false;
                button1.Enabled= false;

            }
            else
            {
                button6.Enabled= true;
                button1.Enabled= true;
            }



            userControl61.Visible = false;
            userControl41.Visible = false;


            //SET DATE AND TIME
            label16.Text= DateTime.Now.ToShortDateString();
            label17.Text= DateTime.Now.ToShortTimeString();


            //SET NAME POST AND DAY
            label12.Text = Form2.a;
            label9.Text = Form2.b;
            label3.Text= DateTime.Now.DayOfWeek.ToString();
            g = label3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ANIMATION PUSHING ATTENDANCE WORD
            pictureBox2.Left -=10;
            pictureBox3.Left -=10;

            label18.Text = (Int32.Parse( label18.Text) + 1).ToString();
            if (label18.Text == "36")
            {
                timer1.Stop();
                pictureBox2.Visible= false;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // ANIMATION PUSHING SIDE BARS
            panel8.Visible = true;
            pictureBox4.Visible = true;
            pictureBox4.Left -= 10;
            panel8.Left-=10;

            panel10.Visible = true;
            pictureBox5.Visible = true;
            pictureBox5.Left += 10;
            panel10.Left += 10;

            label19.Text=(Int32.Parse(label19.Text)+1).ToString();
            if (label19.Text == "15")
            {
                pictureBox5.Visible= false;
                pictureBox4.Visible= false;
                panel9.Visible = true;
                timer2.Stop();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void label3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void userControl41_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 hii = new Form7();
            hii.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 hii = new Form4();
            hii.Show();
            Hide();
            
            userControl63.Visible = false;
            userControl21.Visible = false;
            userControl31.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            userControl21.Visible = true;
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           Form11 hii = new Form11();
            hii.Show();
            Hide();

            userControl63.Visible = false;
            userControl21.Visible = false;
            userControl31.Visible = false;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            userControl31.Visible= true;
            userControl63.Visible = false;
            userControl21.Visible = false;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Form12 hii = new Form12();
            hii.Show();
            Hide();

            userControl63.Visible = false;
            userControl21.Visible = false;
            userControl31.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userControl63.Visible = true;
            userControl63.BringToFront();
            userControl21.Visible = false;
            userControl31.Visible = false;
            userControl41.Visible = false;
            userControl11.Visible = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form16 hii = new Form16();
            hii.Show();
            Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}