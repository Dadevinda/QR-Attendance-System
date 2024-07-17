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
    public partial class UserControl6 : UserControl
    {
        public UserControl6()
        {
            InitializeComponent();
            con = new OleDbConnection(ca.connection());
        }
        Class1 ca = new Class1();
        OleDbConnection con;
        public void load()
        {
            con.Open();
            string c = "select * From Lecturer";
            OleDbCommand cd = new OleDbCommand(c, con);
            OleDbDataReader r = cd.ExecuteReader();
            while (r.Read())
            {
                dataGridView1.Rows.Add(r[0].ToString(), r[1] + " " + r[2].ToString(), r[3].ToString(), r[4].ToString(), r[5].ToString(), r[6].ToString(), r[7].ToString());
              
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form8 hii = new Form8();
            hii.Show();
            Parent.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void UserControl6_Load(object sender, EventArgs e)
        {
            string S = Form2.a;
            if (S == "Member")
            {
                button10.Visible= false;
                button1.Location = button10.Location;
            }
            
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 hii = new Form1();
            hii.Show();
            Parent.Hide();
        }
    }
}
