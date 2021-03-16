using System;


namespace Taxi
{
    class Taxi
    {
        public string drivername { get; set; }
        public bool onduty { get; set; }
        public int numpassenger { get; set; }

        public void Taxiinfo()
        {
            Console.WriteLine("Nama Driver :{0}", drivername);
            if (onduty == true)
            {
                Console.WriteLine("Taxi On Duty: Yes");
            }
            if (onduty == false)
            {
                Console.WriteLine("Taxi On Duty:NO");
            }
            Console.WriteLine("Jumlah Penumpang: {0}",numpassenger);
        }

        public void pickuppassenger()
        {
            Console.WriteLine("{0} Sedang Menjemput Penumpang", drivername);
        }
        public void dropoffpassenger()
        {
            Console.WriteLine("{0} Selesai Mengantarkan Penumpang", drivername);
        }
    }
}
