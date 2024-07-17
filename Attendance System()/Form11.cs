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
using System.Windows.Forms.DataVisualization.Charting;

namespace Attendance_System__
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            con = new OleDbConnection(ca.connection());
            textBox2.Text = DateTime.Now.ToShortTimeString();
            ce();

            pictureBox5.Visible = false;//for male pic
            pictureBox6.Visible = false;// for female pic
            label26.Visible = false;
        }
        int count1;//male students count
        int count2;//female students count
        int count3;//all students count

        Class1 ca = new Class1();
        OleDbConnection con;

        public void ce()
        {
            //load subjects from timetable according to the date
            string M = DateTime.Now.DayOfWeek.ToString();
            textBox3.Text = M;
            con.Open();
            string B = "select Subject_Id from Time_Table where Date = '" + M + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(B, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                comboBox1.Items.Add(row["Subject_Id"]);
                comboBox2.Items.Add(row["Subject_Id"]);
            }
            con.Close();
            textBox3.Text = DateTime.Now.DayOfWeek.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            pictureBox4.Parent = pictureBox3;
            pictureBox4.Parent = this;
            pictureBox4.BackColor = Color.Transparent;
            
            chart1.Series["Students"].Points.AddXY("M", 0);
            chart1.Series["Students"].Points.AddXY("F", 0);

            chart2.Series["Students"].Points.AddXY("M", 0);
            chart2.Series["Students"].Points.AddXY("F", 0);

            chart3.Series["Students"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            chart3.Series["Students"].Points.AddXY("M", 0);
            chart3.Series["Students"].Points.AddXY("F", 0);
            

            chart4.Series["Students"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            chart4.Series["Students"].Points.AddXY("M", 0);
            chart4.Series["Students"].Points.AddXY("F", 0);
           
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            //Get subject name using subject id
            string m = comboBox1.Text;
            con.Open();
            string c = "select Subject_name from Subject where Subject_Id = '" + m + "'";
            OleDbCommand cd = new OleDbCommand(c, con);
            OleDbDataAdapter cmd = new OleDbDataAdapter(c, con);
            DataTable hi = new DataTable();
            cmd.Fill(hi);
            if (hi.Rows.Count > 0)
            {
                textBox1.Text = cd.ExecuteScalar().ToString();
            }
            con.Close();


            //Male count for subject and date
            con.Open();
            string l = "select count(*) from Attendance where Student_Id like '%" + "M" + "%' and A_Date = '" + DateTime.Now.ToShortDateString() + "' and Subject_Id = '" + m + "'";
            OleDbCommand cde = new OleDbCommand(l, con);
            count1 = (int)cde.ExecuteScalar();
            con.Close();
            label5.Text = count1.ToString();
            int d1 = (count1 * 100) / 45;
            progressBar1.Value = d1;

            //Female count for subject and date
            con.Open();
            string g = "select count(*) from Attendance where Student_Id like '%" + "F" + "%' and A_Date = '" + DateTime.Now.ToShortDateString() + "' and Subject_Id = '" + m + "'";
            OleDbCommand t = new OleDbCommand(g, con);
            count2 = (int)t.ExecuteScalar();
            con.Close();
            label6.Text = count2.ToString();
            int dt = (count2 * 100) / 45;
            progressBar2.Value = dt;

            //All student count for subject and date            
            con.Open();
            string df = "select count(*) from Attendance where A_Date = '" + DateTime.Now.ToShortDateString() + "' and Subject_Id = '" + m + "'";
            OleDbCommand v = new OleDbCommand(df, con);
            count3 = (int)v.ExecuteScalar();
            con.Close();
            label7.Text = count3.ToString();

            int gd = (count3 * 100) / 45;
            progressBar3.Value = gd;

            //chart1
            chart1.Series.Clear();
            chart1.Series.Add("Students");
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            chart1.Series["Students"].Points.AddXY("M", count1);
            chart1.Series["Students"].Points.AddXY("F", count2);

            //chart2

            chart2.Series.Clear();
            chart2.Series.Add("Students");
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart2.Series["Students"].Points.AddXY("M", count1);
            chart2.Series["Students"].Points.AddXY("F", count2);

            //chart3
            chart3.Series.Clear();
            chart3.Series.Add("Students");
            chart3.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            chart3.Series["Students"].Points.AddXY("M", count1);
            chart3.Series["Students"].Points.AddXY("F", count2);

            //chart4
            chart4.Series.Clear();
            chart4.Series.Add("Students");
            chart4.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            chart4.Series["Students"].Points.AddXY("M", count1);
            chart4.Series["Students"].Points.AddXY("F", count2);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";

                panel4.BackColor = Color.White;
                panel3.BackColor = Color.White;
            }
            else
            {
                con.Open();
                string k = "select * from Students where Student_Id like '%" + textBox4.Text + "%'";
                OleDbDataAdapter dc = new OleDbDataAdapter(k, con);
                DataTable rf = new DataTable();
                dc.Fill(rf);
                con.Close();
                if (rf.Rows.Count > 0)
                {
                    label26.Visible = false;

                    //attendance mark by student_id
                    panel4.BackColor = Color.White;
                    panel3.BackColor = Color.White;
                    if (comboBox2.Text != "")
                    {
                        string t = comboBox2.Text;
                        con.Open();
                        string s = "select * from Attendance where A_Date = '" + DateTime.Now.ToShortDateString() + "' and Subject_Id = '" + t + "'and Student_Id like '%" + textBox4.Text + "%'";
                        OleDbDataAdapter dt = new OleDbDataAdapter(s, con);
                        DataTable tb = new DataTable();
                        dt.Fill(tb);
                        con.Close();
                        if (tb.Rows.Count > 0)
                        {
                            panel3.BackColor = Color.Green;
                        }
                        else
                        {
                            panel4.BackColor = Color.Red;
                        }
                    }

                    // get name,phone_no,Department from Student_Id
                    con.Open();
                    string y = "select * from Students where Student_Id like '%" + textBox4.Text + "%'";
                    OleDbCommand db = new OleDbCommand(y, con);
                    OleDbDataReader dr = db.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox5.Text = dr.GetValue(1).ToString();
                        textBox6.Text = dr.GetValue(7).ToString();
                        textBox7.Text = dr.GetValue(4).ToString();
                        con.Close();
                    }
                    else { }

                    //male or female picturebox code
                    con.Open();
                    string j = "select Gender from Students where Student_Id like '%" + textBox4.Text + "%'";
                    OleDbCommand bn = new OleDbCommand(j, con);
                    string hj = bn.ExecuteScalar().ToString();
                    con.Close();
                    if (hj == "Male")
                    {
                        pictureBox5.Visible = true;
                        pictureBox6.Visible = false;
                    }
                    if (hj == "Female")
                    {
                        pictureBox5.Visible = false;
                        pictureBox6.Visible = true;
                    }

                }
                else
                {
                    label26.Visible = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            panel4.BackColor = Color.White;
            panel3.BackColor = Color.White;
            if (textBox4.Text != "")
            {
                string t = comboBox2.Text;
                con.Open();
                string s = "select * from Attendance where A_Date = '" + DateTime.Now.ToShortDateString() + "' and Subject_Id = '" + t + "'and Student_Id like '%" + textBox4.Text + "%'";
                OleDbDataAdapter dt = new OleDbDataAdapter(s, con);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                con.Close();
                if (tb.Rows.Count > 0)
                {
                    panel3.BackColor = Color.Green;
                }
                else
                {
                    panel4.BackColor = Color.Red;
                }
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 hii = new Form1();
            hii.Show();
            Hide();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
