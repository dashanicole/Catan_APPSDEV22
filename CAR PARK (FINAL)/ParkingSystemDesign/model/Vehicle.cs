using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystemDesign.model
{
    internal class Vehicle
    {
        // Declaring variables
        private string plateNum, vehicleBrand, selectedVType, vType;
        private string dtIn = DateTime.Now.ToString("MM/dd/yyyy HH:mm"), dtOut = Convert.ToString(DateTime.Now);
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
        public double Amount { get { return amount; } set { amount = value; } }
    }
}
