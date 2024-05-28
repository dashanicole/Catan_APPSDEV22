using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystemDesign.controller
{
    internal class ParkHour
    {
        public double calculateParkTime(string a, string b)
        {
            // Parse strings to DateTime objects
            DateTime startDateTime = DateTime.ParseExact(a, "MM/dd/yyyy HH:mm", null);
            DateTime endDateTime = DateTime.ParseExact(b, "MM/dd/yyyy HH:mm", null);

            // Calculate duration between start and end
            TimeSpan duration = endDateTime - startDateTime;

            // Extract total hours
            return duration.TotalHours;
        }
    }
}
