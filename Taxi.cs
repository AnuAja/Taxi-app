using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTaxi
{
    public class Taxi
    {
        // Properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }

        // Method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver : {0}", DriverName);
            Console.WriteLine("On Duty : {0}", OnDuty);
            Console.WriteLine("Num Passenger : {0}\n", NumPassenger);
        }
        public void PickUpPassanger()
        {
            if (NumPassenger == 0)
            {
                Console.WriteLine("{0} Tidak menjemput penumpang", DriverName);
            }
            else
            {
                Console.WriteLine("{0} Sedang menjemput penumpang", DriverName);
            }
        }
        public void DropOffPassanger()
        {
            if (NumPassenger == 0)
            {
                Console.WriteLine("{0} Tidak mengantar penumpang", DriverName);
            }
            else
            {
                Console.WriteLine("{0} Selesai mengantar penumpang", DriverName);
            }
        }
        public void Line1()
        {
            Console.WriteLine("================================");
        }
        public void Line2()
        {
            Console.WriteLine("================================\n\n\n");
        }
    }
}
