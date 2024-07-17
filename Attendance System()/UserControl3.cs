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
    public partial class UserControl3 : UserControl
    {
        public static string T;
        public static string A;
        string eg;
        string ng;
        string ge;
       
        public UserControl3()
        {
            InitializeComponent();
            userControl11.Visible = false;
            userControl51.Visible = false;

            con = new OleDbConnection(ca.connection());

        }

        Class1 ca = new Class1();
        OleDbConnection con;

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.Visible = false;
            userControl11.BringToFront();
            userControl51.Visible = true; 
           


        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
           
            string b = "8:30 AM";
            string c = "10:30 AM";
            string d = DateTime.Now.DayOfWeek.ToString();


            //for subject button1 to load subject name 
            con.Open();
            string l = "select Subject_Id from Time_Table where Date = '" + d + "' and Time ='" + b + "'";
            OleDbCommand cde = new OleDbCommand(l, con);
            OleDbDataAdapter D = new OleDbDataAdapter(l,con);
            DataTable DT = new DataTable();
            
            D.Fill(DT);
            if (DT.Rows.Count > 0)
            {
                eg = cde.ExecuteScalar().ToString();

                string r = "select Subject_Name from Subject where Subject_Id = '" + eg + "'";
                OleDbCommand cd = new OleDbCommand(r, con);
                ng = cd.ExecuteScalar().ToString();
                button1.Text = ng;
                con.Close();
            }
            else
            {
                button1.Text = "Subject";
            }
                
            //for subject button2 to load subject name 
            con.Open();
            string k = "select Subject_Id from Time_Table where Date = '" + d + "' and Time ='" + c + "'";
            OleDbCommand com = new OleDbCommand(k, con);
           
            OleDbDataAdapter DE = new OleDbDataAdapter(l, con);
            DataTable DTE = new DataTable();
            DE.Fill(DTE);
            if (DTE.Rows.Count > 0)
            {
                ge = com.ExecuteScalar().ToString();
                string m = "select Subject_Name from Subject where Subject_Id = '" + ge + "'";
                OleDbCommand cdd = new OleDbCommand(m, con);
                ng = cdd.ExecuteScalar().ToString();
                button2.Text = ng;
                con.Close();
            }
            else
            {
                button2.Text = "Subject";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.Visible = true;
            userControl51.Visible = false;
            userControl51.BringToFront();
        
           
        }

        private void userControl51_Load(object sender, EventArgs e)
        {

        }
    }

       
}
