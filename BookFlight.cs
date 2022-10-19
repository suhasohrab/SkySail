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
    public partial class BookFlight : Form
    {
        public BookFlight()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\muzna\Documents\FlightReservation.mdb");
        OleDbDataAdapter adap = new OleDbDataAdapter("select * from Schedule", @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\muzna\Documents\FlightReservation.mdb");
        OleDbDataAdapter adap1 = new OleDbDataAdapter("select * from Planes", @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\muzna\Documents\FlightReservation.mdb");
        OleDbDataAdapter adap2 = new OleDbDataAdapter("select * from PassengerDetails", @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\muzna\Documents\FlightReservation.mdb");
        DataSet d1 = new DataSet("FlightReservation");

        string Gender;
        seatReservation reservation1 = new seatReservation();

        int availableSeatOfPlane;
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BookFlight_Load(object sender, EventArgs e)
        {
            con.Open();
            adap1.Fill(d1);
            adap2.Fill(d1);
            adap.Fill(d1, "Schedule");

            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            OleDbCommand com = new OleDbCommand("select * from Planes", con);
            OleDbDataReader r1 = com.ExecuteReader();
            while (r1.Read())
            {
                string a = r1["nameID"].ToString();
                comboBox4.Items.Add(a);
            }

            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            panel1.BackColor = Color.FromArgb(100, 0, 0,0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                if (comboBox1.Text.ToString() == d1.Tables["Schedule"].Rows[i]["Destination"].ToString()
                    && comboBox2.Text.ToString() == d1.Tables["Schedule"].Rows[i]["From"].ToString()
                    && dateTimePicker1.Text == d1.Tables["Schedule"].Rows[i]["Date"].ToString())
                {

                    OleDbCommand com = new OleDbCommand("INSERT into PassengerDetails ([FirstName],[LastName],[PassportID],[Gender],[To],[From],[Date],[SeatClass],[PlaneName],[CreditCardNo]) Values( '" + textBox1.Text + "'," +
                       "'" + textBox3.Text + "','" + textBox2.Text + "','" + Gender + "','" + comboBox1.Text.ToString() + "','" + comboBox2.Text.ToString() + "','" + dateTimePicker1.Text + "','" + comboBox3.Text.ToString() + "','" + comboBox4.Text.ToString() + "','" + maskedTextBox1.Text + "') ", con);
                    com.ExecuteNonQuery();
                    OleDbCommand com2 = new OleDbCommand("Select AvailableSeats from Schedule where ID=@i ", con);
                    com2.Parameters.AddWithValue("i", OleDbType.Integer).Value = i+1;
                    int availableseats = Convert.ToInt32(com2.ExecuteScalar().ToString());
                        availableSeatOfPlane=availableseats-1;
                        OleDbCommand com1 = new OleDbCommand("Update Schedule set AvailableSeats='"+availableSeatOfPlane+"' where ID =@i", con);
                        com1.Parameters.Add("i", OleDbType.Integer).Value = i+1;
                    
                        com1.ExecuteNonQuery();
                    
                    MessageBox.Show("your flight has been confirmed");

                }
                
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            maskedTextBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand com = new OleDbCommand("Update PassengerDetails set FirstName='" + textBox1.Text + "',LastName='" + textBox3.Text + "',SeatClass='" + comboBox3.Text.ToString() + "' where PassportID='" + textBox2.Text + "'", con);
            com.ExecuteNonQuery();

            MessageBox.Show("Information Has been Updated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                if (comboBox1.Text.ToString() == d1.Tables["Schedule"].Rows[i]["Destination"].ToString()
                    && comboBox2.Text.ToString() == d1.Tables["Schedule"].Rows[i]["From"].ToString()
                    && dateTimePicker1.Text == d1.Tables["Schedule"].Rows[i]["Date"].ToString())
                {

                    OleDbCommand com = new OleDbCommand("Delete from PassengerDetails where PassportID='" + textBox2.Text + "'", con);
                    com.ExecuteNonQuery();
                    OleDbCommand com2 = new OleDbCommand("Select AvailableSeats from Schedule where ID=@i ", con);
                    com2.Parameters.AddWithValue("i", OleDbType.Integer).Value = i + 1;
                    int availableseats = Convert.ToInt32(com2.ExecuteScalar().ToString());
                    availableSeatOfPlane = availableseats + 1;
                    OleDbCommand com1 = new OleDbCommand("Update Schedule set AvailableSeats='" + availableSeatOfPlane + "' where ID =@i", con);
                    com1.Parameters.Add("i", OleDbType.Integer).Value = i + 1;

                    com1.ExecuteNonQuery();

                    MessageBox.Show("your Reservation is Cancelled");

                }
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbCommand com = new OleDbCommand("Select * from PassengerDetails where PassportID='" + textBox2.Text + "' ", con);
            OleDbDataReader r1 = com.ExecuteReader();
            if (r1.Read())
            {
                textBox1.Text = r1["FirstName"].ToString();
                textBox3.Text = r1["LastName"].ToString();
                comboBox1.Text = r1["To"].ToString();
                comboBox2.Text = r1["From"].ToString();
                comboBox3.Text= r1["SeatClass"].ToString();
                dateTimePicker1.Text = r1["Date"].ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.Show("Your credit card number Must be of 5 digits", maskedTextBox1,
                maskedTextBox1.Location, 200);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = comboBox5.Text.ToString();
            OleDbDataAdapter adap = new OleDbDataAdapter(" Select Planes.nameID, Schedule.Destination,Schedule.From,Schedule.Date from" +
                " Schedule inner join Planes on Schedule.Flights=Planes.nameID where Destination='" + a + "'", con);
            DataTable d2 = new DataTable("Schedule");
            adap.Fill(d2);
            dataGridView1.DataSource = d2;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbCommand com1 = new OleDbCommand("Select * from Schedule");

            for (int i = 0; i < 11; i++)
            {
                if (comboBox3.SelectedIndex == 0 && comboBox1.Text.ToString() == d1.Tables["Schedule"].Rows[i]["Destination"].ToString()
                        && comboBox2.Text.ToString() == d1.Tables["Schedule"].Rows[i]["From"].ToString()
                        && dateTimePicker1.Text == d1.Tables["Schedule"].Rows[i]["Date"].ToString())
                {
                    textBox4.Text = d1.Tables["Schedule"].Rows[i]["CostPerEconomy"].ToString();
                }

               else if (comboBox3.SelectedIndex == 1 && comboBox1.Text.ToString() == d1.Tables["Schedule"].Rows[i]["Destination"].ToString()
                        && comboBox2.Text.ToString() == d1.Tables["Schedule"].Rows[i]["From"].ToString()
                        && dateTimePicker1.Text == d1.Tables["Schedule"].Rows[i]["Date"].ToString())
                {
                    textBox4.Text = d1.Tables["Schedule"].Rows[i]["CostPerBussiness"].ToString();
                }

               else if (comboBox3.SelectedIndex == 2 && comboBox1.Text.ToString() == d1.Tables["Schedule"].Rows[i]["Destination"].ToString()
                        && comboBox2.Text.ToString() == d1.Tables["Schedule"].Rows[i]["From"].ToString()
                        && dateTimePicker1.Text == d1.Tables["Schedule"].Rows[i]["Date"].ToString())
                {
                    textBox4.Text = d1.Tables["Schedule"].Rows[i]["CostPerFirst"].ToString();
                }
            

            }
        }

    }
}
