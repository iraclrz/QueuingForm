using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queuing_Form
{
    class Parking_Class
    {
        private int x;
        public static string getNumberInQueue = "";
        public static Queue<string> ParkingQueue;

        public Parking_Class()
        {
            x = 1000;
            ParkingQueue = new Queue<string>();
        }
        public string
            ParkingGeneratedNumber(string ParkingNumber)
        {
            x++;
            ParkingNumber = ParkingNumber + x.ToString();
            return ParkingNumber;
        }
    }
}
