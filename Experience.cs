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
    public partial class Experience : Form
    {
        public Experience()
        {
            InitializeComponent();
        }

        private void Experience_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = new Point(0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Baggage f1 = new Baggage();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entertainment f2 = new Entertainment();
            f2.Show();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
