using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightReservation2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
            }
            else if (pictureBox6.Visible == true)
            {
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
            }
            else if(pictureBox7.Visible==true)
            { pictureBox7.Visible = false;
                pictureBox3.Visible = true;
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs f2 = new AboutUs();
            f2.Show();
        }

        private void bookFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookFlight f3 = new BookFlight();
            f3.Show();
        }

        private void dealsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dealscs f4 = new Dealscs();
            f4.Show();
        }

        private void seeScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Schedule f5 = new Schedule();
            f5.Show();
        }
        private void destinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Destination f6 = new Destination();
            f6.Show();
        }

        private void experienceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Experience f7 = new Experience();
            f7.Show();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactUs f8 = new ContactUs();
            f8.Show();
        }

        private void hotelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hotel f9 = new Hotel();
            f9.Show();
        }

        private void employeeLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f10 = new Login();
            f10.Show();
        }

        private void viewTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ticket f11 = new Ticket();
            f11.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
