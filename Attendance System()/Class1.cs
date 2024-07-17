using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Collections;
using System.Data;

namespace Attendance_System__
{
    internal class Class1
    {
       
        OleDbConnection con =new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Dev\\Documents\\Attendance1.accdb");
        OleDbCommand cd;
        OleDbDataAdapter da;
        DataTable dt;
        OleDbDataReader dr;
        string conn;
        string alreadyExist;
        string pdata;
        int idNo;
        public void insert(string query) 
        {
            con.Open();
            cd = new OleDbCommand(query, con);
            cd.ExecuteNonQuery();
            con.Close();
        }
        public string id(string id) 
        {
            con.Open();
            cd = new OleDbCommand(id, con);
            idNo = (int)cd.ExecuteScalar();
            idNo++;
            con.Close();
            string i = idNo.ToString();
            return i;
        }
        public string check(string query)
        {
          con.Open();
          da= new OleDbDataAdapter(query, con);
          dt= new DataTable();
          da.Fill(dt);
          con.Close();
            if (dt.Rows.Count > 0)
            {
                alreadyExist = "yes";
                return alreadyExist;
            }
            else
            {
                alreadyExist = "no";
                return alreadyExist;
            }
                   
        }
        public string data(string query)
        {
            con.Open();
            cd = new OleDbCommand(query,con);
            pdata = (string)cd.ExecuteScalar();
            con.Close();
            return pdata;
        }
        public string connection()
        {
            conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dev\Documents\Attendance1.accdb";
            return conn;
        }
    }
    
}
