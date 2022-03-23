using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek Taxi
            Taxi taxi1 = new Taxi();
            Taxi taxi2 = new Taxi();
            Taxi taxi3 = new Taxi();
            Taxi taxi4 = new Taxi();
            Taxi line = new Taxi();

            // Pengesetan nilai properties
            taxi1.DriverName = "Jono";
            taxi1.OnDuty = true;
            taxi1.NumPassenger = 10;

            taxi2.DriverName = "Joni";
            taxi2.OnDuty = true;
            taxi2.NumPassenger = 6;

            taxi3.DriverName = "Parno";
            taxi3.OnDuty = true;
            taxi3.NumPassenger = 12;

            taxi4.DriverName = "Asep";
            taxi4.OnDuty = false;
            taxi4.NumPassenger = 0;

            // Pemanggilan method
            line.Line1();
            taxi1.TaxiInfo();
            taxi1.PickUpPassanger();
            taxi1.DropOffPassanger();
            line.Line2();

            line.Line1();
            taxi2.TaxiInfo();
            taxi2.PickUpPassanger();
            taxi2.DropOffPassanger();
            line.Line2();

            line.Line1();
            taxi3.TaxiInfo();
            taxi3.PickUpPassanger();
            taxi3.DropOffPassanger();
            line.Line2();

            line.Line1();
            taxi4.TaxiInfo();
            taxi4.PickUpPassanger();
            taxi4.DropOffPassanger();
            line.Line2();
            Console.ReadKey();
        }
    }
}
