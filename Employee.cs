using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FlightReservation2
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\muzna\Documents\FlightReservation.mdb");
        OleDbDataAdapter adap = new OleDbDataAdapter("select * from Schedule", @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\muzna\Documents\FlightReservation.mdb");
        OleDbDataAdapter adap1 = new OleDbDataAdapter("select * from Planes", @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\muzna\Documents\FlightReservation.mdb");
        OleDbDataAdapter adap2 = new OleDbDataAdapter("select * from PassengerDetails", @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\muzna\Documents\FlightReservation.mdb");
        DataSet d1 = new DataSet("FlightReservation");
        int count = 0;
        private void Employee_Load(object sender, EventArgs e)
        {
            con.Open();
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            adap2.Fill(d1);
            adap2.Fill(d1, "PassengerDetails");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(count < d1.Tables["PassengerDetails"].Rows.Count-1)
            {
                count = count + 1;
                textBox1.Text = d1.Tables["PassengerDetails"].Rows[count]["PassportID"].ToString();
                textBox2.Text = d1.Tables["PassengerDetails"].Rows[count]["FirstName"].ToString();
                textBox3.Text = d1.Tables["PassengerDetails"].Rows[count]["LastName"].ToString();
                textBox4.Text = d1.Tables["PassengerDetails"].Rows[count]["To"].ToString();
                textBox5.Text = d1.Tables["PassengerDetails"].Rows[count]["From"].ToString();
                textBox6.Text = d1.Tables["PassengerDetails"].Rows[count]["Date"].ToString();
                textBox7.Text = d1.Tables["PassengerDetails"].Rows[count]["SeatClass"].ToString();
                textBox8.Text = d1.Tables["PassengerDetails"].Rows[count]["PlaneName"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count>0 && count < d1.Tables["PassengerDetails"].Rows.Count - 1)
            {
                count = count - 1;
                textBox1.Text = d1.Tables["PassengerDetails"].Rows[count]["PassportID"].ToString();
                textBox2.Text = d1.Tables["PassengerDetails"].Rows[count]["FirstName"].ToString();
                textBox3.Text = d1.Tables["PassengerDetails"].Rows[count]["LastName"].ToString();
                textBox4.Text = d1.Tables["PassengerDetails"].Rows[count]["To"].ToString();
                textBox5.Text = d1.Tables["PassengerDetails"].Rows[count]["From"].ToString();
                textBox6.Text = d1.Tables["PassengerDetails"].Rows[count]["Date"].ToString();
                textBox7.Text = d1.Tables["PassengerDetails"].Rows[count]["SeatClass"].ToString();
                textBox8.Text = d1.Tables["PassengerDetails"].Rows[count]["PlaneName"].ToString();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbCommand com = new OleDbCommand("DELETE from PassengerDetails where PassportID='" + textBox1.Text + "'", con);
            com.ExecuteNonQuery();

            MessageBox.Show(" Reservation  Cancelled");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbCommand com = new OleDbCommand("Select * from PassengerDetails where " +
                "PassportID='" + textBox1.Text + "' ", con);
            OleDbDataReader r1 = com.ExecuteReader();
            if (r1.Read())
            {
                textBox2.Text = r1["FirstName"].ToString();
                textBox3.Text = r1["LastName"].ToString();
                textBox4.Text = r1["To"].ToString();
                textBox5.Text = r1["From"].ToString();
                textBox7.Text = r1["SeatClass"].ToString();
                textBox6.Text = r1["Date"].ToString();
                textBox8.Text = r1["PlaneName"].ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear(); 
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }
    }
}
