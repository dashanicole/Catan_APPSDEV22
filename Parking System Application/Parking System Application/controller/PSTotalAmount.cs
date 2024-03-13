using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking_System_Application.view;
using Parking_System_Application.model;

namespace Parking_System_Application.controller
{
    internal class PSTotalAmount
    {
        public double totalAmount(double parktime, string vtype)
        {
            PSVehicle v = new PSVehicle();

            switch (vtype)
            { 
                case "Motorbike": v = new PSMotorbike(); break;
                case "SUV": v = new PSSUV(); break;
                case "Van": v = new PSVan(); break;
                case "Sedan": v = new PSSedan(); break;
            }

            // Calculation for the total amount
            return v.FlagDown + (v.AddPerHr * parktime);
        }
    }
}
