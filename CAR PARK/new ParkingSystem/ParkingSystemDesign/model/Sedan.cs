using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystemDesign.model
{
    internal class Sedan : Vehicle
    {
        public Sedan() // constructor
        {
            FlagDown = 30.00;
            AddPerHr = 15.00;
        }
    }
}
