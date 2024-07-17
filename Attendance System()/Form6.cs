using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Attendance_System__
{
    public partial class Form6 : Form
    {

        public Form6()
        {
            InitializeComponent();
            con = new OleDbConnection(ca.connection());
        }
        Class1 ca = new Class1();
        OleDbConnection con;

        string a1;
        string a2;


        public void LOAD1() 
        {
            string id = textBox3.Text;
            if (textBox3.Text != "")
            {
                con.Open();
                string i1 = "Select * from Attendance where Subject_Id='" + id + "' and A_Date ='" + DateTime.Now.ToShortDateString() + "'";
                OleDbCommand cdr = new OleDbCommand(i1, con);
                OleDbDataReader dr = cdr.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[5].ToString(), dr[4].ToString());
                }
                con.Close();
            }
        }
       
        // load video input devices to combo box
        FilterInfoCollection fill;
        VideoCaptureDevice vc;
        private void Form6_Load(object sender, EventArgs e)
        {
          
            
            fill = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo na in fill)
                comboBox1.Items.Add(na.Name);


            comboBox1.SelectedIndex = 0;



            //load subjects from timetable according to the date
            string M = DateTime.Now.DayOfWeek.ToString();

            con.Open();
            string B = "select Subject_Id from Time_Table where Date = '" + M + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(B, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {

                    comboBox2.Items.Add(row["Subject_Id"]);

                }
                con.Close();
            }
            else { }

            // select subject 8.30 AM
            string t = DateTime.Now.DayOfWeek.ToString();
            string ti = "8:30 AM";
            
            con.Open();
            string Be = "select Subject_Id from Time_Table where Date = '" + t + "'and Time ='" + ti + "'";
            OleDbCommand cd = new OleDbCommand(Be, con);
            OleDbDataAdapter dr = new OleDbDataAdapter(Be, con);
            DataTable tb = new DataTable();
            dr.Fill(tb);
            if (tb.Rows.Count > 0)
            {
                a2 = cd.ExecuteScalar().ToString();

            }
            con.Close() ;

            // select subject 10.30 AM
            string t1 = DateTime.Now.DayOfWeek.ToString();
            string ti1 = "10:30 AM";
           
            con.Open();
            string Be1 = "select Subject_Id from Time_Table where Date = '" + t1 + "'and Time ='" + ti1 + "'";
            OleDbCommand cd1 = new OleDbCommand(Be1, con);
            OleDbDataAdapter dr1 = new OleDbDataAdapter(Be1, con);
            DataTable tb1 = new DataTable();
            dr1.Fill(tb1);
            if (tb1.Rows.Count > 0)
            {
                a1 = cd1.ExecuteScalar().ToString();

            }
            con.Close() ;

            //select subject id according to the current time
            int f = DateTime.Now.Hour;
            int f1 = f * 60;
            int f2 = f1 + DateTime.Now.Minute;

            if (f2 > 510 && f2 < 630)
            {
                textBox3.Text = a2;

            }
            else if (f2 < 750)
            {
                textBox3.Text = a1;

            }

            else if (f2 > 750)
            {
                textBox3.Text = "";
            }

            textBox4.Text = DateTime.Now.ToShortDateString();
            textBox5.Text = DateTime.Now.ToShortTimeString();




        }


        private void capture(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vc = new VideoCaptureDevice(fill[comboBox1.SelectedIndex].MonikerString);
            vc.NewFrame += capture;
            vc.Start();
            timer2.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox3.Text;

            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox3.Text == "")
            {

            }
            else { 

            con.Open();
            string b = "Select * from Attendance where Student_Id ='" + textBox2.Text + "' and Subject_Id ='" + id + "' and A_Date = '"+DateTime.Now.ToShortDateString()+"'";
            OleDbDataAdapter cmd = new OleDbDataAdapter(b, con);
            DataTable hi = new DataTable();
            cmd.Fill(hi);
                if (hi.Rows.Count > 0)
                {
                    MessageBox.Show("Already exist","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    dataGridView1.Rows.Clear();   
                    con.Close();
                }
                else
                {
                    string pr = "present";                  
                    string sc = "insert into Attendance(Student_Id,Subject_Id,Sem_Id,A_Date,Atten,A_Time)values" + "(@student_id,@subject_id,@sem_id,@dat,@atten,@time)";
                    OleDbCommand cp = new OleDbCommand(sc, con);
        
                    cp.Parameters.AddWithValue("@student_id", textBox2.Text);
                    cp.Parameters.AddWithValue("@subject_id", textBox3.Text);
                    cp.Parameters.AddWithValue("@sem_id", comboBox3.Text);
                    cp.Parameters.AddWithValue("@dat", textBox4.Text);
                    cp.Parameters.AddWithValue("@atten",pr);
                    cp.Parameters.AddWithValue("@time", textBox5.Text);
                    cp.ExecuteNonQuery();
                   

                    dataGridView1.Rows.Clear();
                    if (textBox3.Text != "")
                    {
                        string i1 = "Select * from Attendance where Subject_Id='" + id + "' and A_Date ='" + DateTime.Now.ToShortDateString() + "'";
                        OleDbCommand cdr = new OleDbCommand(i1, con);
                        OleDbDataReader dr = cdr.ExecuteReader();
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[5].ToString(), dr[4].ToString());
                        }
                        con.Close();
                    }

                }
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
          
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader br = new BarcodeReader();
                Result rs = br.Decode((Bitmap)pictureBox1.Image);

            
                if (rs != null)
                {
                    button2.Enabled = true;
                    label6.Text = rs.ToString().Trim();
                    textBox2.Text= rs.ToString().Trim();
                    timer1.Stop();
                    vc.Stop();
                }
            }
        }

        private void label6_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = label6.Text;
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LOAD1();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text= comboBox2.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form14 hii = new Form14();
            hii.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            label6.Text = "";

         pictureBox1.Image= null;
         
            vc.Stop();
            timer1.Stop();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            

            dataGridView1.Rows.Clear();

            string id = textBox3.Text;
            if (textBox3.Text != "")
            {
                con.Open();
                string i1 = "Select * from Attendance where Subject_Id='" + id + "' and A_Date ='" + DateTime.Now.ToShortDateString() + "'";
                OleDbCommand cdr = new OleDbCommand(i1, con);
                OleDbDataReader dr = cdr.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[5].ToString(), dr[4].ToString());
                }
                con.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            int index = e.RowIndex;
            if (index > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                textBox6.Text = selectedRow.Cells[0].Value.ToString();
                textBox7.Text = selectedRow.Cells[1].Value.ToString();
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {           
            con.Open();
            string s = "delete from Attendance where Student_Id = '" + textBox6.Text + "' and Subject_Id = '" + textBox7.Text + "' and A_Date = '" + DateTime.Now.ToShortDateString() + "'";
            OleDbCommand cd = new OleDbCommand(s,con);
            cd.ExecuteNonQuery();
            con.Close();
            dataGridView1.Rows.Clear();

            con.Open();
            string id = textBox3.Text;
            string i1 = "Select * from Attendance where Subject_Id='" + id + "' and A_Date ='" + DateTime.Now.ToShortDateString() + "'";
            OleDbCommand cdr = new OleDbCommand(i1, con);
            OleDbDataReader dr = cdr.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[5].ToString(), dr[4].ToString());
            }
            con.Close() ;
            textBox6.Text = "";
            textBox6.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
