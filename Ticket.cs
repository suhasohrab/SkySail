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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\muzna\Documents\FlightReservation.mdb");
        OleDbDataAdapter adap = new OleDbDataAdapter("select * from Schedule", @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\muzna\Documents\FlightReservation.mdb");
        OleDbDataAdapter adap1 = new OleDbDataAdapter("select * from PassengerDetails", @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\muzna\Documents\FlightReservation.mdb");
        DataSet d1 = new DataSet("FlightReservation");

        string spacedetails = "{0, -10}{1, -10}{2, -10}";
        private void Ticket_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
           
            con.Open();
            adap1.Fill(d1);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            listBox1.Items.Clear();
            OleDbCommand com = new OleDbCommand("Select * from PassengerDetails where " +
                "PassportID='" + textBox1.Text + "'", con);
            OleDbDataReader r1 = com.ExecuteReader();
            while(r1.Read())
            {
                listBox1.Items.Add(String.Format(spacedetails, "F Name :", "\t", r1["FirstName"].ToString()));
                listBox1.Items.Add(String.Format(spacedetails, "L Name :", "\t", r1["LastName"].ToString()));
                listBox1.Items.Add(String.Format(spacedetails, "Gender :", "\t", r1["Gender"].ToString()));
                listBox1.Items.Add(String.Format(spacedetails, "To :", "\t", r1["To"].ToString()));
                listBox1.Items.Add(String.Format(spacedetails, "From :", "\t", r1["From"].ToString()));
                listBox1.Items.Add(String.Format(spacedetails, "Date :", "\t", r1["Date"].ToString()));
                listBox1.Items.Add(String.Format(spacedetails, "Seat :", "\t", r1["SeatClass"].ToString()));
                listBox1.Items.Add(String.Format(spacedetails, "Flight :", "\t", r1["PlaneName"].ToString()));
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
