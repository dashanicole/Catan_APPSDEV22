using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_System
{
    internal class Vehicle
    {
        public string plateNum = "", vehicleBrand = "", selectedVType = "", vType = "";
        public string[] vehicleType = { "Motorbike", "SUV", "Van", "Sedan" };
        public string dtIn = Convert.ToString(DateTime.Now), dtOut = Convert.ToString(DateTime.Now);
        public int parkTime = 0;
        public double flagDown = 0.00, addPerHr = 0.00, amount = 0.00;


        public string inputPlateNum()
        {
            Console.Write("Enter the Plate Number: ");
            return Console.ReadLine();
        }

        public string selectVType()
        {
            int num = 1;

            Console.WriteLine("\nVehicle Types:");
            foreach (string s in vehicleType)
            {
                Console.WriteLine("[" + num + "] " + s);
                num++;
            }

            Console.Write("Select Vehicle Type: ");
            int numSelect = Convert.ToInt32(Console.ReadLine());
            return vehicleType[numSelect-1];
        }

        public string inputVBrand()
        {
            Console.Write("\nEnter the Vehicle Brand: ");
            return Console.ReadLine();
        }

        public void displayParkIn()
        {
            Console.WriteLine("\n--- PARK IN INFO ---");
            Console.WriteLine("Plate No.: " + plateNum);
            Console.WriteLine("Type: " + selectedVType);
            Console.WriteLine("Brand: " + vehicleBrand);
            Console.WriteLine("Park In (Date/Time): " + dtIn);
        }

        public class Motorbike : Vehicle
        {
            public Motorbike(string dtIN)
            {
                dtIn = dtIN;
                vType = "Motorbike";
                flagDown = 20.00;
                addPerHr = 5.00;
            }
        }

        public class SUV : Vehicle
        {
            public SUV(string dtIN)
            {
                dtIn = dtIN;
                vType = "SUV";
                flagDown = 40.00;
                addPerHr = 20.00;
            }
        }

        public class Van : Vehicle
        {
            public Van(string dtIN)
            {
                dtIn = dtIN;
                vType = "SUV";
                flagDown = 40.00;
                addPerHr = 20.00;
            }
        }

        public class Sedan : Vehicle
        {
            public Sedan(string dtIN)
            {
                dtIn = dtIN;
                vType = "Sedan";
                flagDown = 30.00;
                addPerHr = 15.00;
            }
        }

        public DateTime askTimeParkOut()
        {
            Console.Write("\nEnter the Time Park Out (24-Hour Format): ");
            return Convert.ToDateTime(Console.ReadLine());
        }

        public int calculateParkTime()
        {
            int timeInHr = Convert.ToInt32(Convert.ToDateTime(dtIn).ToString("HH:mm").Substring(0,2));
            int timeInMin = Convert.ToInt32(Convert.ToDateTime(dtIn).ToString("HH:mm").Substring(3));
            int timeOutHr = Convert.ToInt32(Convert.ToDateTime(dtOut).ToString("HH:mm").Substring(0,2));
            int timeOutMin = Convert.ToInt32(Convert.ToDateTime(dtOut).ToString("HH:mm").Substring(3));

            if (timeInMin > timeOutMin)
            {
                return timeOutHr-- - timeInHr;
            }
            else if (timeInHr > timeOutHr)
            {
                int count = 0;
                for (; timeInHr!=24; timeInHr++) { count++; }
                return count + timeOutHr;
            }
            else
            {
                return timeOutHr - timeInHr;
            }
        }

        public void totalAmount(double flagDown)
        {
            amount = flagDown + (addPerHr * parkTime);
        }

        public void displayParkOut()
        {
            Console.WriteLine("\n--- PARK OUT INFO ---");
            Console.WriteLine("Date/Time In: " + dtIn);
            Console.WriteLine("         Out: " + dtOut);
            if (parkTime > 1) { Console.WriteLine("Parking Time: " + parkTime + " hrs"); }
            else { Console.WriteLine("Parking Time: " + parkTime + " hr"); }
            Console.WriteLine("Amount: " + amount);
        }
    }
}
