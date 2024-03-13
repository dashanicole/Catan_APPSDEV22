using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_System_Application.model
{
    internal class PSMotorbike : PSVehicle
    {
        public PSMotorbike() // constructor
        {
            FlagDown = 20.00;
            AddPerHr = 5.00;
        }
    }
}
