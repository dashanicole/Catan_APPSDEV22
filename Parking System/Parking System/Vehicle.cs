using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Parking_System
{
    internal class Vehicle // Vehicle class
    {
        // Declaring variables
        private string plateNum, vehicleBrand, selectedVType, vType;
        private string[] vehicleType = { "Motorbike", "SUV", "Van", "Sedan" };
        private string dtIn = Convert.ToString(DateTime.Now), dtOut = Convert.ToString(DateTime.Now);
        private double parkTime, flagDown, addPerHr, amount;

        // Setters and getters
        public string PlateNum { get { return plateNum; } set { plateNum = value; } }
        public string VehicleBrand { get { return vehicleBrand; } set { vehicleBrand = value; } }
        public string SelectedVType { get { return selectedVType; } set { selectedVType = value; } }
        public string VType { get { return vType; } set { vType = value; } }
        public string DtIn { get { return dtIn; } set { dtIn = value; } }
        public string DtOut { get { return dtOut; } set { dtOut = value; } }
        public double ParkTime { get { return parkTime; } set { parkTime = value; } }
        public double FlagDown { get { return flagDown; } set { flagDown = value; } }
        public double AddPerHr { get { return addPerHr; } set { addPerHr = value; } }

        // inputPlateNum method
        public string inputPlateNum()
        {
            string pltNm;

            do
            {
                // Asking for the plate number
                Console.Write("Enter the Plate Number: ");
                pltNm = Console.ReadLine();

                if (invalidInputStr(pltNm)) { Console.WriteLine("\nInvalid input! Please enter again..."); }

            } while (invalidInputStr(pltNm)); // let the user enter again if invalid

            return pltNm;
        }

        // selectVType method
        public string selectVType()
        {
            int num = 1;
            string numSelect;

            do
            {
                // Asking the user to select vehicle type
                Console.WriteLine("\nVehicle Types:");
                foreach (string s in vehicleType)
                {
                    Console.WriteLine("[" + num + "] " + s);
                    num++;
                }

                num = 1;

                Console.Write("Select Vehicle Type: ");
                numSelect = Console.ReadLine();

                if (invalidInputSlct(numSelect)) { Console.Write("\nInvalid input! Please select again..."); }

            } while (invalidInputSlct(numSelect)); // let the user enter again if invalid

            return vehicleType[Convert.ToInt32(numSelect) - 1];
        }

        // inputVBrand method
        public string inputVBrand()
        {
            string vBrnd;

            do
            {
                // Asking for the vehicle brand
                Console.Write("\nEnter the Vehicle Brand: ");
                vBrnd = Console.ReadLine();

                if (vBrnd.Length == 0) { Console.Write("\nInvalid input! Please enter again..."); }

            } while (vBrnd.Length == 0); // let the user enter again if invalid

            return vBrnd;
        }

        // displayParkIn method
        public void displayParkIn() // display park-in info
        {
            string dtin = Convert.ToDateTime(dtIn).ToString("MM/dd/yyyy HH:mm");

            Console.WriteLine("\n--- PARK IN INFO ---");
            Console.WriteLine($"Plate No.: {plateNum}");
            Console.WriteLine($"Type: {selectedVType}");
            Console.WriteLine($"Brand: {vehicleBrand}");
            Console.WriteLine($"Park In (Date/Time): {dtin}");
        }

        // Motorbike class inherited the Vehicle class
        public class Motorbike : Vehicle
        {
            public Motorbike(string dtIN) // constructor
            {
                dtIn = dtIN;
                vType = "Motorbike";
                flagDown = 20.00;
                addPerHr = 5.00;
            }
        }
        // SUV class inherited the Vehicle class
        public class SUV : Vehicle
        {
            public SUV(string dtIN) // constructor
            {
                dtIn = dtIN;
                vType = "SUV";
                flagDown = 40.00;
                addPerHr = 20.00;
            }
        }

        // Van class inherited the Vehicle class
        public class Van : Vehicle
        {
            public Van(string dtIN) // constructor
            {
                dtIn = dtIN;
                vType = "SUV";
                flagDown = 40.00;
                addPerHr = 20.00;
            }
        }

        // Sedan class inherited the Vehicle class
        public class Sedan : Vehicle
        {
            public Sedan(string dtIN) // constructor
            {
                dtIn = dtIN;
                vType = "Sedan";
                flagDown = 30.00;
                addPerHr = 15.00;
            }
        }

        // askTimeParkOut method
        public string askTimeParkOut()
        {
            string time;

            do
            {
                // Asking user for the park-out time
                Console.Write("\nEnter the Date/Time Park Out (MM/dd/yyyy HH/mm): ");
                time = Console.ReadLine();

                if (invalidInputTime(time, dtIn)) { Console.Write("\nInvalid input! Please enter again..."); }

            } while (invalidInputTime(time, dtIn)); // let the user enter again if invalid

            return time;
        }

        // calculateParkTime method
        public double calculateParkTime()
        {
            string dtin = Convert.ToDateTime(dtIn).ToString("MM/dd/yyyy HH:mm");

            // Parse strings to DateTime objects
            DateTime startDateTime = DateTime.ParseExact(dtin, "MM/dd/yyyy HH:mm", null);
            DateTime endDateTime = DateTime.ParseExact(dtOut, "MM/dd/yyyy HH:mm", null);

            // Calculate duration between start and end
            TimeSpan duration = endDateTime - startDateTime;

            // Extract total hours
            return duration.TotalHours;
        }

        // totalAmount method
        public void totalAmount(double flagDown)
        {
            // Calculation for the total amount
            amount = flagDown + (addPerHr * parkTime);
        }

        // displayParkOut method
        public void displayParkOut() // display the park-out info
        {
            string dtin = Convert.ToDateTime(dtIn).ToString("MM/dd/yyyy HH:mm");

            Console.WriteLine("\n--- PARK OUT INFO ---");
            Console.WriteLine($"Date/Time In: {dtin}");
            Console.WriteLine($"         Out: {dtOut}");
            if (parkTime > 1) { Console.WriteLine($"Parking Time: {Math.Round(parkTime)} hrs"); }
            else { Console.WriteLine($"Parking Time: {Math.Round(parkTime)} hr"); }
            Console.WriteLine($"Amount: PHP{String.Format("{0:0.00}", amount)}");
        }

        // invalidInputStr method
        static bool invalidInputStr(string input)
        {
            bool invalidInput = false;

            // To check if the input is valid or not
            if (input.Length == 0) { invalidInput = true; }
            else
            {
                for (int x = 0; x < input.Length; x++)
                {
                    char ch = input[x];

                    if (Char.IsWhiteSpace(ch)) { invalidInput = true; }
                }
            }

            return invalidInput;
        }

        // invalidInputSlct method
        static bool invalidInputSlct(string input)
        {
            bool invalidInput = false;

            // To check if the input is valid or not
            if (invalidInputStr(input)) { invalidInput = true; }
            else if (input.Length > 1) { invalidInput = true; }
            else if (!Char.IsDigit(input[0])) { invalidInput = true; }
            else if (1 > Convert.ToInt32(input) || Convert.ToInt32(input) > 4) { invalidInput = true; }

            return invalidInput;
        }

        // invalidInputChs method
        public bool invalidInputChs(string input)
        {
            bool invalidInput = false;

            // To check if the input is valid or not
            if (invalidInputStr(input)) { invalidInput = true; }
            else if (input.Length > 1) { invalidInput = true; }
            else if (!Char.IsDigit(input[0])) { invalidInput = true; }
            else if (1 > Convert.ToInt32(input) || Convert.ToInt32(input) > 2) { invalidInput = true; }

            return invalidInput;
        }

        // invalidInputTime method
        static bool invalidInputTime(string input, string dtIN)
        { 
            bool invalidInput = false;

            // To check if the input is valid or not
            if (input.Length != 16) { invalidInput = true; }
            else
            {
                // For Date
                if (!Char.IsDigit(input[0]) || !Char.IsDigit(input[1]) || input[2] != '/' || !Char.IsDigit(input[3])
                    || !Char.IsDigit(input[4]) || input[5] != '/' || !Char.IsDigit(input[6]) || !Char.IsDigit(input[7])
                    || !Char.IsDigit(input[8]) || !Char.IsDigit(input[9]) || input[10] != ' ')
                {
                    invalidInput = true; 
                }
                // Year Limit
                else if (Convert.ToInt32(Convert.ToDateTime(dtIN).ToString("yyyy")) > Convert.ToInt32(input.Substring(6, 4)))
                {
                    invalidInput = true; 
                }
                // Month Limit
                else if (0 > Convert.ToInt32(input.Substring(0, 2)) || Convert.ToInt32(input.Substring(0, 2)) > 12
                    || ((Convert.ToInt32(Convert.ToDateTime(dtIN).ToString("MM")) > Convert.ToInt32(input.Substring(0, 2))
                    && Convert.ToInt32(Convert.ToDateTime(dtIN).ToString("yyyy")) == Convert.ToInt32(input.Substring(6, 4)))))
                {
                    invalidInput = true;
                }
                // Day Limit
                // February (leap year)
                else if (Convert.ToInt32(input.Substring(0, 2)) == 2 && (Convert.ToInt32(input.Substring(6, 4)) % 400 == 0
                    || (Convert.ToInt32(input.Substring(6, 4)) % 100 != 0 && Convert.ToInt32(input.Substring(6, 4)) % 4 == 0))
                    && (0 > Convert.ToInt32(input.Substring(3, 2)) || Convert.ToInt32(input.Substring(3, 2)) > 29))
                {
                    invalidInput = true;
                }
                // February 
                else if (Convert.ToInt32(input.Substring(0, 2)) == 2 && (0 > Convert.ToInt32(input.Substring(3, 2))
                    || Convert.ToInt32(input.Substring(3, 2)) > 28))
                {
                    invalidInput = true; 
                }
                // April, June, September, November
                else if ((Convert.ToInt32(input.Substring(0, 2)) == 4 || Convert.ToInt32(input.Substring(0, 2)) == 6
                    || Convert.ToInt32(input.Substring(0, 2)) == 9 || Convert.ToInt32(input.Substring(0, 2)) == 11)
                    && (0 > Convert.ToInt32(input.Substring(3, 2)) || Convert.ToInt32(input.Substring(3, 2)) > 30))
                {
                    invalidInput = true; 
                }
                // January, March, May, July, August, October, December
                else if ((Convert.ToInt32(input.Substring(0, 2)) == 1 || Convert.ToInt32(input.Substring(0, 2)) == 3
                    || Convert.ToInt32(input.Substring(0, 2)) == 5 || Convert.ToInt32(input.Substring(0, 2)) == 7
                    || Convert.ToInt32(input.Substring(0, 2)) == 8 || Convert.ToInt32(input.Substring(0, 2)) == 10
                    || Convert.ToInt32(input.Substring(0, 2)) == 12) && (0 > Convert.ToInt32(input.Substring(3, 2))
                    || Convert.ToInt32(input.Substring(3, 2)) > 31))
                {
                    invalidInput = true; 
                }
                else if (Convert.ToInt32(Convert.ToDateTime(dtIN).ToString("dd")) > Convert.ToInt32(input.Substring(3, 2))
                    && Convert.ToInt32(Convert.ToDateTime(dtIN).ToString("MM")) > Convert.ToInt32(input.Substring(0, 2)))
                {
                    invalidInput = true; 
                }

                // For Time
                else if (!Char.IsDigit(input[11]) || !Char.IsDigit(input[12]) || input[13] != ':'
                    || !Char.IsDigit(input[14]) || !Char.IsDigit(input[15]))
                {
                    invalidInput = true; 
                }
                // Hour Limit
                else if ((0 > Convert.ToInt32(input.Substring(11, 2)) || Convert.ToInt32(input.Substring(11, 2)) > 23))
                {
                    invalidInput = true; 
                }
                // Minute Limit
                else if ((0 > Convert.ToInt32(input.Substring(14)) || Convert.ToInt32(input.Substring(14)) > 59))
                {
                    invalidInput = true; 
                }
            }
   
            return invalidInput;
        }
    }
}
