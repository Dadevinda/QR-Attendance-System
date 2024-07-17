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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
       Class1 ca = new Class1();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {
           

            //time table for monday morning(optimised)
            string date1 = "Monday";
            string time1 = "8:30 AM";
            String q1 = "select Subject_Id from Time_Table where Date = '" + date1 + "' and  Time = '" + time1 + "'";
            string check1 = ca.check(q1);

            if (check1 == "yes")
            {
                string d1 = ca.data(q1);
                String q21 = "select Subject_Name from Subject where Subject_Id = '" + d1 + "'";
                textBox1.Text = ca.data(q21);
            }
            else
            {

            }
            

            //time table for monday afternoon(optimised)
            string date2 = "Monday";
            string time2 = "10:30 AM";
            String q2 = "select Subject_Id from Time_Table where Date = '" + date2 + "' and  Time = '" + time2 + "'";
            string check2 = ca.check(q2);

            if (check2 == "yes")
            {
                string d2 = ca.data(q2);
                String q22 = "select Subject_Name from Subject where Subject_Id = '" + d2 + "'";
                textBox2.Text = ca.data(q22);
            }
            else
            {

            }

           


            //time table for tuesday morning(optimised)
            string date3 = "Tuesday";
            string time3 = "8:30 AM";
            String q3 = "select Subject_Id from Time_Table where Date = '" + date3 + "' and  Time = '" + time3 + "'";
            string check3 = ca.check(q3);

            if (check3 == "yes")
            {
                string d3 = ca.data(q3);
                String q23 = "select Subject_Name from Subject where Subject_Id = '" + d3 + "'";
                textBox3.Text = ca.data(q23);
            }
            else
            {

            }

            
            //time table for tuesday afternoon(optimised)
            string date4 = "Tuesday";
            string time4 = "10:30 AM";
            String q4 = "select Subject_Id from Time_Table where Date = '" + date4 + "' and  Time = '" + time4 + "'";
            string check4 = ca.check(q4);

            if (check4 == "yes")
            {
                string d4 = ca.data(q4);
                String q24 = "select Subject_Name from Subject where Subject_Id = '" + d4 + "'";
                textBox4.Text = ca.data(q24);
            }
            else
            {

            }


          

            //time table for wednesday morning(optimised)
            string date5 = "Wednesday";
            string time5 = "8:30 AM";
            String q5 = "select Subject_Id from Time_Table where Date = '" + date5 + "' and  Time = '" + time5 + "'";
            string check5 = ca.check(q5);

            if (check5 == "yes")
            {
                string d5 = ca.data(q5);
                String q25 = "select Subject_Name from Subject where Subject_Id = '" + d5 + "'";
                textBox5.Text = ca.data(q25);
            }
            else
            {

            }

           

            //time table for wednesday afternoon(optimised)
            string date6 = "Wednesday";
            string time6 = "10:30 AM";
            String q6 = "select Subject_Id from Time_Table where Date = '" + date6 + "' and  Time = '" + time6 + "'";
            string check6 = ca.check(q6);

            if (check6 == "yes")
            {
                string d6 = ca.data(q6);
                String q26 = "select Subject_Name from Subject where Subject_Id = '" + d6 + "'";
                textBox6.Text = ca.data(q26);
            }
            else
            {

            }

           
            //time table for thursday morning(optimised)
            string date7 = "Thursday";
            string time7 = "8:30 AM";
            String q7 = "select Subject_Id from Time_Table where Date = '" + date7 + "' and  Time = '" + time7 + "'";
            string check7 = ca.check(q7);

            if (check7 == "yes")
            {
                string d7 = ca.data(q7);
                String q27 = "select Subject_Name from Subject where Subject_Id = '" + d7 + "'";
                textBox7.Text = ca.data(q27);
            }
            else
            {

            }

         

            //time table for thursday afternoon(optimised)
            string date8 = "Thursday";
            string time8 = "10:30 AM";
            String q8 = "select Subject_Id from Time_Table where Date = '" + date8 + "' and  Time = '" + time8 + "'";
            string check8 = ca.check(q8);

            if (check8 == "yes")
            {
                string d8 = ca.data(q8);
                String q28 = "select Subject_Name from Subject where Subject_Id = '" + d8 + "'";
                textBox8.Text = ca.data(q28);
            }
            else
            {

            }

            

            //time table for friday morning(optimised)
            string date9 = "Friday";
            string time9 = "8:30 AM";
            String q9 = "select Subject_Id from Time_Table where Date = '" + date9 + "' and  Time = '" + time9 + "'";
            string check9 = ca.check(q9);

            if (check9 == "yes")
            {
                string d9 = ca.data(q9);
                String q29 = "select Subject_Name from Subject where Subject_Id = '" + d9 + "'";
                textBox9.Text = ca.data(q29);
            }
            else
            {

            }

            

            //time table for friday afternoon(optimised)
            string date10 = "Friday";
            string time10 = "10:30 AM";
            String q10 = "select Subject_Id from Time_Table where Date = '" + date10 + "' and  Time = '" + time10 + "'";
            string check10 = ca.check(q10);

            if (check10 == "yes")
            {
                string d10 = ca.data(q10);
                String q210 = "select Subject_Name from Subject where Subject_Id = '" + d10 + "'";
                textBox10.Text = ca.data(q210);
            }
            else
            {

            }

          

            //time table for sunday morning(optimised)
            string date11 = "Sunday";
            string time11 = "8:30 AM";
            String q11 = "select Subject_Id from Time_Table where Date = '" + date11 + "' and  Time = '" + time11 + "'";
            string check11 = ca.check(q11);

            if (check11 == "yes")
            {
                string d11 = ca.data(q11);
                String q211 = "select Subject_Name from Subject where Subject_Id = '" + d11 + "'";
                textBox11.Text = ca.data(q211);
            }
            else
            {

            }

           

            //time table for sunday afternoon(optimised)
            string date12 = "Sunday";
            string time12 = "10:30 AM";
            String q12 = "select Subject_Id from Time_Table where Date = '" + date12 + "' and  Time = '" + time12 + "'";
            string check12 = ca.check(q12);

            if (check12 == "yes")
            {
                string d12 = ca.data(q12);
                String q212 = "select Subject_Name from Subject where Subject_Id = '" + d12 + "'";
                textBox12.Text = ca.data(q212);
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 hii = new Form1();
            hii.Show();
            Hide();
        }
    }
}
