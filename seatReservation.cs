using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace FlightReservation2
{
    class seatReservation
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\muzna\Documents\FlightReservation.mdb");
        OleDbDataAdapter adap = new OleDbDataAdapter("select * from Schedule", @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\muzna\Documents\FlightReservation.mdb");
        OleDbDataAdapter adap1 = new OleDbDataAdapter("select * from Planes", @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\muzna\Documents\FlightReservation.mdb");
        DataSet d1 = new DataSet("FlightReservation");

        string firstvariable = string.Empty;
        private int[] totalSeats = new int[5] { 700, 450, 550, 750, 500 };
        private int[] reservedSeats = new int[11];
        private string[] planeName = new string[5] { "AirBus 4210", "AirBus 4707", "Boeing 315", "Boeing 707", "Boeing 7730" };
        public void assignTotalSeats()
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\muzna\Documents\FlightReservation.mdb");
            con.Open();
            for (int j = 0; j < 5; j++)
            {

                OleDbCommand command = new OleDbCommand("Update Planes set TotalSeats='" + totalSeats[j] + "' where nameID='" + planeName[j] + "'", con);
                command.ExecuteNonQuery();

            }

        }
    }
}
