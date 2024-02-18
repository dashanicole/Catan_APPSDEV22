using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
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
        private int parkTime;
        private double flagDown, addPerHr, amount;

        // Setters and getters
        public string PlateNum { get { return plateNum; } set { plateNum = value; } }
        public string VehicleBrand { get { return vehicleBrand; } set { vehicleBrand = value; } }
        public string SelectedVType { get { return selectedVType; } set { selectedVType = value; } }
        public string VType { get { return vType; } set { vType = value; } }
        public string DtIn { get { return dtIn; } set { dtIn = value; } }
        public string DtOut { get { return dtOut; } set { dtOut = value; } }
        public int ParkTime { get { return parkTime; } set { parkTime = value; } }
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

                if (invalidInputStr(vBrnd)) { Console.Write("\nInvalid input! Please enter again..."); }

            } while (invalidInputStr(vBrnd)); // let the user enter again if invalid

            return vBrnd;
        }

        // displayParkIn method
        public void displayParkIn() // display park-in info
        {
            Console.WriteLine("\n--- PARK IN INFO ---");
            Console.WriteLine("Plate No.: " + plateNum);
            Console.WriteLine("Type: " + selectedVType);
            Console.WriteLine("Brand: " + vehicleBrand);
            Console.WriteLine("Park In (Date/Time): " + dtIn);
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
        public DateTime askTimeParkOut()
        {
            string time;

            do
            {
                // Asking user for the park-out time
                Console.Write("\nEnter the Time Park Out (24-Hour Format): ");
                time = Console.ReadLine();

                if (invalidInputTime(time)) { Console.Write("\nInvalid input! Please enter again..."); }

            } while (invalidInputTime(time)); // let the user enter again if invalid

            return Convert.ToDateTime(time);
        }

        // calculateParkTime method
        public int calculateParkTime()
        {
            // Calculation for the park time
            int timeInHr = Convert.ToInt32(Convert.ToDateTime(dtIn).ToString("HH:mm").Substring(0, 2));
            int timeInMin = Convert.ToInt32(Convert.ToDateTime(dtIn).ToString("HH:mm").Substring(3));
            int timeOutHr = Convert.ToInt32(Convert.ToDateTime(dtOut).ToString("HH:mm").Substring(0, 2));
            int timeOutMin = Convert.ToInt32(Convert.ToDateTime(dtOut).ToString("HH:mm").Substring(3));

            if (timeInMin > timeOutMin)
            {
                if (timeInHr > timeOutHr || timeInHr == timeOutHr)
                {
                    int count = 0;
                    for (; timeInHr != 24; timeInHr++) { count++; }
                    return count + timeOutHr;
                }
                else
                {
                    return timeOutHr-- - timeInHr;
                }
            }
            else
            {
                if (timeInHr > timeOutHr || timeInHr == timeOutHr)
                {
                    int count = 0;
                    for (; timeInHr != 24; timeInHr++) { count++; }
                    return count + timeOutHr;
                }
                else
                {
                    return timeOutHr - timeInHr;
                }
            }
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
            Console.WriteLine("\n--- PARK OUT INFO ---");
            Console.WriteLine("Date/Time In: " + dtIn);
            Console.WriteLine("         Out: " + dtOut);
            if (parkTime > 1) { Console.WriteLine("Parking Time: " + parkTime + " hrs"); }
            else { Console.WriteLine("Parking Time: " + parkTime + " hr"); }
            Console.WriteLine("Amount: " + amount);
        }

        // invalidInputStr method
        static bool invalidInputStr(String input)
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
        static bool invalidInputSlct(String input)
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
        public bool invalidInputChs(String input)
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
        static bool invalidInputTime(String input)
        { 
            bool invalidInput = false;

            // To check if the input is valid or not
            if (invalidInputStr(input)) { invalidInput = true; }
            else if (input.Length > 5 || input.Length < 4) { invalidInput = true; }
            else if (input.Length == 5) 
            {
                if (!Char.IsDigit(input[0]) || !Char.IsDigit(input[1]) || input[2] != ':' 
                    || !Char.IsDigit(input[3]) || !Char.IsDigit(input[4])) 
                {
                    invalidInput = true;
                }
                else if (0 > Convert.ToInt32(input.Substring(0, 2)) || Convert.ToInt32(input.Substring(0,2)) > 23 
                    || 0 > Convert.ToInt32(input.Substring(3)) || Convert.ToInt32(input.Substring(3)) > 59) 
                {
                    invalidInput = true;
                }
            }
            else if (input.Length == 4) 
            {
                if (!Char.IsDigit(input[0]) || input[1] != ':' || !Char.IsDigit(input[2]) 
                    || !Char.IsDigit(input[3]))
                {
                    invalidInput = true;
                }
                else if (0 > Convert.ToInt32(input.Substring(0, 1)) || Convert.ToInt32(input.Substring(0, 1)) > 9
                    || 0 > Convert.ToInt32(input.Substring(2)) || Convert.ToInt32(input.Substring(2)) > 59)
                {
                    invalidInput = true;
                }
            }

            return invalidInput;
        }
    }
}
