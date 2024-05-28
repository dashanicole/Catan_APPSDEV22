using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystemDesign.model
{
    internal class Motorbike : Vehicle
    {
        public Motorbike() // constructor
        {
            FlagDown = 20.00;
            AddPerHr = 5.00;
        }
    }
}
