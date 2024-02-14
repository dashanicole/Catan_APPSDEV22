using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_System
{
    internal class ParkSystem   
    {
        static void Main(string[] args) 
        {
            Vehicle v = new Vehicle();
            v.plateNum = v.inputPlateNum();
            v.selectedVType = v.selectVType();
            v.vehicleBrand = v.inputVBrand();
            v.displayParkIn();

            switch (v.selectedVType)
            {
                case "Motorbike": v = new Vehicle.Motorbike(v.dtIn); break;
                case "SUV": v = new Vehicle.SUV(v.dtIn); break;
                case "Van": v = new Vehicle.Van(v.dtIn); break;
                case "Sedan": v = new Vehicle.Sedan(v.dtIn); break;
            }

            Console.WriteLine("\nCHOOSE AN OPTION: \n[1] PARK OUT \n[2] CANCEL");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    v.dtOut = Convert.ToString(v.askTimeParkOut());
                    v.parkTime = v.calculateParkTime(); 
                    v.totalAmount(v.flagDown);
                    v.displayParkOut();
                    
                    // just to check
                    Console.WriteLine("\nCHECK INFO:\nVehicle: " + v.vType + "\nFlag Down: " + v.flagDown + "\nAdditional per Hour: " + v.addPerHr);
                    break;

                case 2:
                    Console.WriteLine("\nYou cancelled the transaction.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
