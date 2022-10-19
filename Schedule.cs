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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\muzna\Documents\FlightReservation.mdb");
        OleDbDataAdapter adap = new OleDbDataAdapter("select * from Schedule", @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\muzna\Documents\FlightReservation.mdb");
        OleDbDataAdapter adap1 = new OleDbDataAdapter("select * from Planes", @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\muzna\Documents\FlightReservation.mdb");
        DataSet d1 = new DataSet("FlightReservation");

        string spacedetails = "{0, -10}{1, -10}{2, -10}";
        seatReservation reservation1 = new seatReservation();
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            con.Open();
            adap.Fill(d1, "Schedule");
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\muzna\Documents\FlightReservation.mdb");
            OleDbDataAdapter adap = new OleDbDataAdapter("select * from Schedule", con);
            DataTable d2 = new DataTable("Schedule");
            adap.Fill(d2);
            dataGridView1.DataSource = d2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < 10; i++)
            {
                if (comboBox1.Text == d1.Tables["Schedule"].Rows[i]["Destination"].ToString() && comboBox2.Text == d1.Tables["Schedule"].Rows[i]["From"].ToString())
                {
                    MessageBox.Show("We have an available flight");

                    listBox1.Items.Add(String.Format(spacedetails, "Flight Name :", "\t", d1.Tables["Schedule"].Rows[i]["Flights"].ToString()));
                    listBox1.Items.Add(String.Format(spacedetails, "Date :", "\t", d1.Tables["Schedule"].Rows[i]["Date"].ToString()));
                    listBox1.Items.Add(String.Format(spacedetails, "Time :", "\t", d1.Tables["Schedule"].Rows[i]["Time"].ToString()));
                    listBox1.Items.Add(String.Format(spacedetails, "Available seats On Flight :", "\t", d1.Tables["Schedule"].Rows[i]["AvailableSeats"].ToString()));
                    listBox1.Items.Add(String.Format(spacedetails, "Price of Economy Seat :", "\t", d1.Tables["Schedule"].Rows[i]["CostPerEconomy"].ToString()));
                    listBox1.Items.Add(String.Format(spacedetails, "Price of Bussiness Seat :", "\t", d1.Tables["Schedule"].Rows[i]["CostPerBussiness"].ToString()));
                    listBox1.Items.Add(String.Format(spacedetails, "Price of First Class Seat :", "\t", d1.Tables["Schedule"].Rows[i]["CostPerFirst"].ToString()));
                }

            }

            reservation1.assignTotalSeats();
        }
    }
}
