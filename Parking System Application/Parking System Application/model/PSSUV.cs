using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_System_Application.model
{
    internal class PSSUV : PSVehicle
    {
        public PSSUV() // constructor
        {
            FlagDown = 40.00;
            AddPerHr = 20.00;
        }
    }
}
