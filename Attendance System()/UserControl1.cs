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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            con = new OleDbConnection(ca.connection());
        }
        string ege;

        Class1 ca = new Class1();
        OleDbConnection con;
        public void Load1() 
        {
            //select subject id
            string b = "10:30 AM";
            string d = DateTime.Now.DayOfWeek.ToString();
 
            con.Open();
            string l = "select Subject_Id from Time_Table where Date = '" + d + "' and Time ='" + b + "'";
            OleDbCommand cde = new OleDbCommand(l, con);
            DataTable fd = new DataTable();
            OleDbDataAdapter ade = new OleDbDataAdapter(l, con);
            ade.Fill(fd);
            if (fd.Rows.Count > 0)
            {
                ege = cde.ExecuteScalar().ToString();
                con.Close();
                //select subject name
                con.Open();
                string rd = "select Subject_Name from Subject where Subject_Id = '" + ege + "'";
                OleDbCommand cd = new OleDbCommand(rd, con);
                string ng = cd.ExecuteScalar().ToString();
                con.Close();

                con.Open();
                string v = "select count(*) from students";
                OleDbCommand cm = new OleDbCommand(v, con);
                int c = (int)cm.ExecuteScalar();
                con.Close();
                for (int i = 1; i <= c; i++)
                {
                   //load gridview
                   con.Open();
                    string k = "select * from Attendance where A_Date = '" + DateTime.Now.ToShortDateString() + "'and Subject_Id ='" + ege + "'and Student_Id like '%" + i + "%'";
                    OleDbCommand cdd = new OleDbCommand(k, con);
                    OleDbDataReader r = cdd.ExecuteReader();
              
                    if (r.Read())
                    {
                        dataGridView1.Rows.Add(DateTime.Now.ToShortDateString(), r[0].ToString(), ng, "Present");
                        con.Close();
                    }
                    
                    else
                    {
                        
                        string w = "select * from Students where Student_Id like '%" + i + "%'";
                        OleDbCommand cdde = new OleDbCommand(w, con);
                        OleDbDataReader rde = cdde.ExecuteReader();
                       
                        if (rde.Read())
                        {
                            dataGridView1.Rows.Add(DateTime.Now.ToShortDateString(), rde[0].ToString(), ng, "Absent");
                            con.Close();
                        }
                      con.Close();
                    }
                }
              
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            Load1();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            Parent.Hide();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Load1();
        }
    }
}
