using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Attendance_System__
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
            ce = new OleDbConnection(ca.connection());
        }
        Class1 ca = new Class1();
        OleDbConnection ce = new OleDbConnection();
        
        public void dta()
        {
            if (comboBox1.Text != "" && textBox2.Text != "" && comboBox2.Text != "")
            {
                string id = comboBox1.Text;
                string ui = textBox1.Text;
                string si = comboBox2.Text;
                string ng = textBox3.Text;
                
                //OleDbConnection c = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ASUS\\Documents\\Attendance1.accdb");
                ce.Open();
                string k = "select * from Attendance where Sem_Id='" + si + "' and Subject_Id ='" + id + "'and Student_Id like '%" + ui + "%'";
                OleDbCommand cdd = new OleDbCommand(k, ce);
                OleDbDataReader r = cdd.ExecuteReader();
                OleDbDataAdapter dt = new OleDbDataAdapter(k, ce);
                
                DataTable dr = new DataTable();
                dt.Fill(dr);

                if (dr.Rows.Count > 0)
                {

                    while (r.Read())
                    {
                        dataGridView1.Rows.Add(r[3], r[5].ToString(), r[0].ToString(), ng, r[4].ToString());

                    }
                }
                ce.Close();
            }
            else { }


        }
        public void dta1()
        {
            if (comboBox3.Text != "" && comboBox4.Text != "")
            {
                string id = comboBox3.Text;
                string si = comboBox4.Text;
                string di=dateTimePicker1.Value.ToShortDateString();
                string ng = textBox4.Text;

                //OleDbConnection c = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ASUS\\Documents\\Attendance1.accdb");
                ce.Open();
                string k = "select * from Attendance where Sem_Id='" + si + "' and Subject_Id ='" + id + "'and A_Date = '" + di + "'";
                OleDbCommand cdd = new OleDbCommand(k, ce);
                OleDbDataReader r = cdd.ExecuteReader();
                OleDbDataAdapter dt = new OleDbDataAdapter(k, ce);
               
                DataTable dr = new DataTable();
                dt.Fill(dr);         
                if (dr.Rows.Count > 0)
                {

                    while (r.Read())
                    {
                        dataGridView2.Rows.Add(di, r[5].ToString(), r[0].ToString(), ng, r[4].ToString());

                    }
              
                }
                ce.Close();
            }
            else { }
        }
        private void Form16_Load(object sender, EventArgs e)
        {
            textBox5.Text=DateTime.Now.ToShortTimeString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            string A = comboBox1.Text;
            //OleDbConnection d = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ASUS\\Documents\\Attendance1.accdb");
            ce.Open();
            string c = "select Subject_Name from Subject where Subject_Id = '" + A + "'";
            OleDbCommand cd = new OleDbCommand(c, ce);
            OleDbDataAdapter cmd = new OleDbDataAdapter(c, ce);
 
            DataTable hi = new DataTable();
            cmd.Fill(hi);
            if (hi.Rows.Count > 0)
            {
                textBox3.Text = cd.ExecuteScalar().ToString();
            }
            ce.Close();
            dataGridView1.Rows.Clear();
            dta();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string B = textBox1.Text;

                //OleDbConnection d = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ASUS\\Documents\\Attendance1.accdb");
                ce.Open();
                string c = "select F_Name from Students where Student_Id = '" + B + "'";
                OleDbCommand cd = new OleDbCommand(c, ce);
                OleDbDataAdapter cmd = new OleDbDataAdapter(c,ce);
            
                DataTable hi = new DataTable();
                cmd.Fill(hi);
              
                if (hi.Rows.Count > 0)
                {
                    textBox2.Text = cd.ExecuteScalar().ToString();
                }
                else
                {
                    textBox2.Text = "";
                }
            }
            else 
            {
                textBox2.Text = "";
            
            }
            ce.Close();
            dataGridView1.Rows.Clear();
            dta();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dta();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            string A = comboBox3.Text;
            //OleDbConnection d = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ASUS\\Documents\\Attendance1.accdb");
            ce.Open();
            string c = "select Subject_Name from Subject where Subject_Id = '" + A + "'";
            OleDbCommand cd = new OleDbCommand(c, ce);
            OleDbDataAdapter cmd = new OleDbDataAdapter(c, ce);
            DataTable hi = new DataTable();
            cmd.Fill(hi);
           
            if (hi.Rows.Count > 0)
            {
                textBox4.Text = cd.ExecuteScalar().ToString();
            }
            ce.Close();
            dataGridView2.Rows.Clear();
            dta1();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dta1();
        }

        private void comboBox4_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dta1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog DG = new SaveFileDialog();
                DG.Filter = "PDF (*.pdf)|*.pdf";
                DG.FileName = "Student_Record.pdf";

               
                    if (DG.ShowDialog() == DialogResult.OK)
                {
                        PdfPTable pdf = new PdfPTable(dataGridView1.Columns.Count);
                    pdf.DefaultCell.Padding = 2;
                    pdf.WidthPercentage= 100;
                    pdf.HorizontalAlignment = Element.ALIGN_LEFT;
              
                       foreach (DataGridViewColumn col in dataGridView1.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText));
                            pdf.AddCell(cell);
                        }
                        foreach (DataGridViewRow viewRow in dataGridView1.Rows)
                        {
                            foreach (DataGridViewCell dcell in viewRow.Cells)
                            {
                                pdf.AddCell(dcell.Value.ToString());
                            }
                        }
                        using (FileStream fs = new FileStream(DG.FileName, FileMode.Create))
                        {
                            Document dc = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                            PdfWriter.GetInstance(dc, fs);
                            dc.Open();
                            dc.Add(pdf);
                            dc.Close();
                            fs.Close();
                        }
                    }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                SaveFileDialog DG = new SaveFileDialog();
                DG.Filter = "PDF (*.pdf)|*.pdf";
                DG.FileName = "Subject_Record.pdf";


                if (DG.ShowDialog() == DialogResult.OK)
                {
                    PdfPTable pdf = new PdfPTable(dataGridView2.Columns.Count);
                    pdf.DefaultCell.Padding = 2;
                    pdf.WidthPercentage = 100;
                    pdf.HorizontalAlignment = Element.ALIGN_LEFT;

                    foreach (DataGridViewColumn col in dataGridView2.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText));
                        pdf.AddCell(cell);
                    }
                    foreach (DataGridViewRow viewRow in dataGridView2.Rows)
                    {
                        foreach (DataGridViewCell dcell in viewRow.Cells)
                        {
                            pdf.AddCell(dcell.Value.ToString());
                        }
                    }
                    using (FileStream fs = new FileStream(DG.FileName, FileMode.Create))
                    {
                        Document dc = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                        PdfWriter.GetInstance(dc, fs);
                        dc.Open();
                        dc.Add(pdf);
                        dc.Close();
                        fs.Close();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            comboBox2.Text="";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            textBox4.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 hii = new Form1();
            hii.Show();
            Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
