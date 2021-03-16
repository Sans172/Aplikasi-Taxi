using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat taxi
            Taxi taxi = new Taxi();

            //pengesetan nilai properti
            taxi.drivername = "Azriel";
            taxi.onduty = true;
            taxi.numpassenger = 10;

            taxi.Taxiinfo();
            taxi.pickuppassenger();
            taxi.dropoffpassenger();

            Console.ReadKey();
        }
    }
}
