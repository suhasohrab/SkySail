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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\muzna\Documents\FlightReservation.mdb");
        OleDbDataAdapter adap = new OleDbDataAdapter("select * from Schedule", @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\muzna\Documents\FlightReservation.mdb");
        OleDbDataAdapter adap1 = new OleDbDataAdapter("select * from Employee", @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\muzna\Documents\FlightReservation.mdb");
        OleDbDataAdapter adap2 = new OleDbDataAdapter("select * from PassengerDetails", @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\muzna\Documents\FlightReservation.mdb");
        DataSet d1 = new DataSet("FlightReservation");

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            adap1.Fill(d1,"Employee");
        }

        private void button1_Click(object sender, EventArgs e)
        {   for (int i = 0; i < 5; i++)
            {
                if (textBox1.Text.ToString()==d1.Tables["Employee"].Rows[i]["EmployeeID"].ToString()
                    && textBox2.Text.ToString()==d1.Tables["Employee"].Rows[i]["Password"].ToString())
                { Employee f1 = new Employee();
                    f1.Show();
                }
                else
                { toolTip1.Show("unidentified user",textBox1,textBox1.Location,200); }
            }
        }
    }
}
