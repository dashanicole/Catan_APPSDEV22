using ParkingSystemDesign.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystemDesign.controller
{
    internal class TotalAmount
    {
        public double totalAmount(double parktime, string vtype)
        {
            Vehicle v = new Vehicle();

            switch (vtype)
            {
                case "Motorbike": v = new Motorbike(); break;
                case "SUV": v = new Suv(); break;
                case "Van": v = new Van(); break;
                case "Sedan": v = new Sedan(); break;
            }

            // Calculation for the total amount
            return v.FlagDown + (v.AddPerHr * parktime);
        }
    }
}
