using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystemDesign.model
{
    internal class Suv : Vehicle
    {
        public Suv() // constructor
        {
            FlagDown = 40.00;
            AddPerHr = 20.00;
        }
    }
}
