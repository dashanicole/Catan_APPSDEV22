using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_System
{
    internal class ParkSystem // ParkSystem class
    {
        static void Main(string[] args) // Main method
        {
            string userPark = "";
            Vehicle v = new Vehicle(); // creating a new object

            do {
                // Calling methods for setting values
                v.PlateNum = v.inputPlateNum();
                v.SelectedVType = v.selectVType();
                v.VehicleBrand = v.inputVBrand();

                v.displayParkIn(); // display park-in info

                string num;

                do
                {
                    // Asking the user if wants to park out or cancel the transaction
                    Console.WriteLine("\nCHOOSE AN OPTION: \n[1] PARK OUT \n[2] CANCEL");
                    num = Console.ReadLine();

                    if (v.invalidInputChs(num)) { Console.Write("\nInvalid input! Please choose again..."); }

                } while (v.invalidInputChs(num)); // let the user enter again if invalid

                switch (Convert.ToInt32(num))
                {
                    case 1: // Park-out

                        switch (v.SelectedVType) // selecting the user's vehicle type
                        {
                            // creating an object for park-out info
                            case "Motorbike": v = new Vehicle.Motorbike(v.DtIn); break;
                            case "SUV": v = new Vehicle.SUV(v.DtIn); break;
                            case "Van": v = new Vehicle.Van(v.DtIn); break;
                            case "Sedan": v = new Vehicle.Sedan(v.DtIn); break;
                        }

                        // Calling methods for setting values
                        v.DtOut = v.askTimeParkOut();
                        v.ParkTime = v.calculateParkTime();

                        v.totalAmount(v.FlagDown); // a method for calculating the total amount
                        v.displayParkOut(); // display park-out info

                        // just to check the info
                        Console.WriteLine($"\n--- CHECK INFO --- \nVehicle: {v.VType} \nFlag Down: " +
                            $"{v.FlagDown} \nAdditional per Hour: {v.AddPerHr}");
                        break;

                    case 2: // Cancellation
                        Console.WriteLine("\nYou cancelled the transaction.");
                        break;
                }

                do
                {
                    // Asking the user if wants to park again
                    Console.WriteLine("\nDo you want to park again? \n[1] Yes \n[2] No"); 
                    userPark = Console.ReadLine();

                    if (v.invalidInputChs(userPark)) { Console.Write("\nInvalid input! Please enter again..."); }

                } while (v.invalidInputChs(userPark));  // let the user enter again if invalid

                Console.WriteLine();

            } while (Convert.ToInt32(userPark) == 1);

            Console.Write("Thank you and come again...");

            Console.ReadKey();
        }
    }
}
