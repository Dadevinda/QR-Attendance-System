using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Attendance_System__
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            id();
        }
        public void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            checkBox2.Checked = false;
        }
        public void t1()
        {
            if (textBox1.Text == "")
            {
                label21.Visible = false;
                label20.Visible = true;
            }
            else
            {
                label21.ForeColor = Color.Black;
                label21.Visible = true;
                label20.Visible = false;
                textBox1.Text = textBox1.Text;
            }
        }
        public void t2()
        {
            if (textBox2.Text == "")
            {
                label19.Visible = false;
                label6.Visible = true;
            }
            else
            {
                label19.ForeColor = Color.Black;
                label19.Visible = true;
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
                    label9.Visible = true;
            }
                else
                {
                    label8.ForeColor = Color.Black;
                    label8.Visible = true;
                    label9.Visible = false;
                     label7.Visible = false;
                textBox3.Text = textBox3.Text;
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
        public void id()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ASUS\Documents\Attendance1.accdb;";
            conn.Open();
            OleDbCommand cd = new OleDbCommand("select count(id) from d", conn);
           
            int i = Convert.ToInt32(cd.ExecuteScalar());
            i++;
            textBox8.Text = i.ToString();
            conn.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ASUS\Documents\Attendance1.accdb;";
            conn.Open();

            //string[] s = { "1", "2", "3", "4", "5" };
            for (int i = 0; i < 12; i++)
            {

                string c = "select * From d where Id like('" + i + "')";

                OleDbCommand cd = new OleDbCommand(c, conn);
                OleDbDataReader r = cd.ExecuteReader();

                while (r.Read())
                {
                    dataGridView1.Rows.Add(r[0].ToString(), r[1].ToString(), r[2].ToString(), r[3].ToString(), r[4].ToString(), r[5].ToString());
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            textBox1.Text = selectedRow.Cells[0].Value.ToString();
            textBox2.Text = selectedRow.Cells[1].Value.ToString();
            textBox3.Text = selectedRow.Cells[2].Value.ToString();
            textBox4.Text = selectedRow.Cells[3].Value.ToString();
            textBox5.Text = selectedRow.Cells[4].Value.ToString();
            textBox7.Text = selectedRow.Cells[5].Value.ToString();


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label20.Visible = true;
                label21.Visible = false;
            }
            else
            {
                label21.Visible = true;
                label20.Visible = false;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                label6.Visible = true;
                label19.Visible = false;
            }
            else
            {
                label19.Visible = true;
                label6.Visible = false;

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                label7.Visible = true;
                label9.Visible = true;
                label8.Visible = false;
            }
            else
            {
                label8.Visible = true;
                label9.Visible = false;
                label7.Visible = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                label10.Visible = true;
                label11.Visible = false;
            }
            else
            {
                label11.Visible = true;
                label10.Visible = false;

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                label13.Visible = true;
                label12.Visible = false;
            }
            else
            {
                label12.Visible = true;
                label13.Visible = false;

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                label17.Visible = true;
                label15.Visible = false;
            }
            else
            {
                label15.Visible = true;
                label17.Visible = false;

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox7.UseSystemPasswordChar = true;
            }
            else
            {
                textBox7.UseSystemPasswordChar = false;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                label18.Visible = true;
                label16.Visible = false;
            }
            else
            {
                label16.Visible = true;
                label18.Visible = false;

            }
        }

        private void textBox8_MouseClick(object sender, MouseEventArgs e)
        {
            label16.Visible = true;
            label18.Visible = false;
            label16.ForeColor = Color.DodgerBlue;
            t1();
            t2();
            t3();
            t4();
            t5();
            t7();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            label21.Visible = true;
            label20.Visible = false;
            label21.ForeColor = Color.DodgerBlue;
            t8();
            t2();
            t3();
            t4();
            t5();
            t7();
            
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            label19.Visible = true;
            label6.Visible = false;
            label19.ForeColor = Color.DodgerBlue;
            t1();
            t8();
            t3();
            t4();
            t5();
            t7();
        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            label8.Visible = true;
            label7.Visible = false;
            label9.Visible = false;
            label8.ForeColor = Color.DodgerBlue;
            t1();
            t2();
            t8();
            t4();
            t5();
            t7();
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            label8.Visible = true;
            label7.Visible = false;
            label9.Visible = false;
            label8.ForeColor = Color.DodgerBlue;
            t1();
            t2();
            t8();
            t4();
            t5();
            t7();
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            label11.Visible = true;
            label10.Visible = false;
            label11.ForeColor = Color.DodgerBlue;
            t1();
            t8();
            t3();
            t2();
            t5();
            t7();
        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            label12.Visible = true;
            label13.Visible = false;
            label12.ForeColor = Color.DodgerBlue;
            t1();
            t8();
            t3();
            t2();
            t4();
            t7();
        }

        private void textBox7_MouseClick(object sender, MouseEventArgs e)
        {
            label15.Visible = true;
            label17.Visible = false;
            label15.ForeColor = Color.DodgerBlue;

            t1();
            t8();
            t3();
            t2();
            t5();
            t4();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            label15.Visible = true;
            label17.Visible = false;
            label15.ForeColor = Color.DodgerBlue;
            textBox7.Focus();
            t1();
            t8();
            t3();
            t2();
            t5();
            t4();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            label12.Visible = true;
            label13.Visible = false;
            label12.ForeColor = Color.DodgerBlue;
            textBox5.Focus();
            t1();
            t8();
            t3();
            t2();
            t4();
            t7();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label11.Visible = true;
            label10.Visible = false;
            label11.ForeColor = Color.DodgerBlue;
            textBox4.Focus();
            t1();
            t8();
            t3();
            t2();
            t5();
            t7();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            label7.Visible = false;
            label9.Visible = false;
            label8.ForeColor = Color.DodgerBlue;
            textBox3.Focus();
            t1();
            t2();
            t8();
            t4();
            t5();
            t7();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            label7.Visible = false;
            label9.Visible = false;
            label8.ForeColor = Color.DodgerBlue;
            textBox3.Focus();
            t1();
            t2();
            t8();
            t4();
            t5();
            t7();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label19.Visible = true;
            label6.Visible = false;
            label19.ForeColor = Color.DodgerBlue;
            textBox2.Focus();
            t1();
            t8();
            t3();
            t4();
            t5();
            t7();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            label21.Visible = true;
            label20.Visible = false;
            label21.ForeColor = Color.DodgerBlue;
            textBox1.Focus();
            t8();
            t2();
            t3();
            t4();
            t5();
            t7();
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

        private void button1_Click(object sender, EventArgs e)
        {
          

                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ASUS\Documents\Attendance1.accdb;";
                conn.Open();
                string s = "insert into d (id,email,phone,post,username,pass,name)values" + "(@id,@email,@phone,@post,@username,@pass,@name)";
                OleDbCommand cd = new OleDbCommand(s, conn);
               
                cd.Parameters.AddWithValue("@id", textBox8.Text);
                cd.Parameters.AddWithValue("@email", textBox3.Text);
                cd.Parameters.AddWithValue("@phone", textBox5.Text);
                cd.Parameters.AddWithValue("@post", textBox6.Text);
                cd.Parameters.AddWithValue("@username", textBox4.Text);
                cd.Parameters.AddWithValue("@pass", textBox7.Text);
                cd.Parameters.AddWithValue("@name", textBox1.Text);
                cd.ExecuteNonQuery();

            dataGridView1.Rows.Clear();

                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ASUS\Documents\Attendance1.accdb;";
                cnn.Open();

                //string[] s = { "1", "2", "3", "4", "5" };
                for (int i = 0; i < 12; i++)
                {

                    string c = "select * From d where Id like('" + i + "')";

                    OleDbCommand cid = new OleDbCommand(c, conn);
                    OleDbDataReader r = cid.ExecuteReader();

                    while (r.Read())
                    {
                        dataGridView1.Rows.Add(r[0].ToString(), r[1].ToString(), r[2].ToString(), r[3].ToString(), r[4].ToString(), r[5].ToString());
                    }
                }


                //OleDbConnection con = new OleDbConnection();
                //con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ASUS\Documents\Database4.accdb;Persist Security Info=False;";
                //con.Open();
                //    string sd = "insert into lo (id,username,pass)values" + "(@id,@username,@pass)";
                //    OleDbCommand cmd = new OleDbCommand(sd, conn);

                //    cmd.Parameters.AddWithValue("@id", textBox8.Text);                
                //    cmd.Parameters.AddWithValue("@username", textBox4.Text);
                //    cmd.Parameters.AddWithValue("@pass", textBox7.Text);

                //    cmd.ExecuteNonQuery();
                //    conn.Close();
                //    clear();
                //}
                //else
                //{

            }

            private void button3_Click(object sender, EventArgs e)
        {
            Form1 hii = new Form1();
            hii.Show();
            Hide();
        }
    }
}
