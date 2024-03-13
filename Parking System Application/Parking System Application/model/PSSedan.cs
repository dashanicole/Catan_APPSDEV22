using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_System_Application.model
{
    internal class PSSedan : PSVehicle
    {
        public PSSedan() // constructor
        {
            FlagDown = 30.00;
            AddPerHr = 15.00;
        }
    }
}
