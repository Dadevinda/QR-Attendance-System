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
    public partial class UserControl2 : UserControl
    {
        public static string yu;
        public UserControl2()
        {
            InitializeComponent();
            con = new OleDbConnection(ca.connection());
        }
        Class1 ca = new Class1();
        OleDbConnection con;
        public void load()
        {
            con.Open();
            string c = "select * From Students";
            OleDbCommand cd = new OleDbCommand(c, con);
            OleDbDataReader r = cd.ExecuteReader();
            while (r.Read())
            {
                dataGridView1.Rows.Add(r[0].ToString(), r[1] + " " + r[2].ToString(), r[3].ToString(), r[4].ToString(), r[5].ToString(), r[6].ToString(), r[7].ToString(), r[8].ToString());
            }
            con.Close();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

            string S = Form2.a;
            if (S == "Member")
            {
                button3.Visible = false;
                button1.Location = button3.Location;
            }

            
            load();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 hii = new Form1();
            hii.Show();
           Parent.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 hii = new Form9();
            hii.Show();
            Parent.Hide();
            yu = "add";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
