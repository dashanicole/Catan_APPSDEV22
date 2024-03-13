using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_System_Application.controller
{
    internal class PSDateTimeChecker
    {
        public bool invalidInputTime(string input, string dtIN)
        {
            bool invalidInput = false;

            // To check if the input is valid or not
            if (input.Length != 16) { invalidInput = true; }
            else
            {
                // For Date
                if (!Char.IsDigit(input[0]) || !Char.IsDigit(input[1]) || input[2] != '/' || !Char.IsDigit(input[3])
                    || !Char.IsDigit(input[4]) || input[5] != '/' || !Char.IsDigit(input[6]) || !Char.IsDigit(input[7])
                    || !Char.IsDigit(input[8]) || !Char.IsDigit(input[9]) || input[10] != ' ')
                {
                    invalidInput = true;
                }
                // Year Limit
                else if (Convert.ToInt32(dtIN.Substring(6, 4)) > Convert.ToInt32(input.Substring(6, 4)))
                {
                    invalidInput = true;
                }
                // Month Range
                else if (0 > Convert.ToInt32(input.Substring(0, 2)) || Convert.ToInt32(input.Substring(0, 2)) > 12)
                {
                    invalidInput = true;
                }
                // Day Limit
                // February (leap year)
                else if (Convert.ToInt32(input.Substring(0, 2)) == 2 && (Convert.ToInt32(input.Substring(6, 4)) % 400 == 0
                    || (Convert.ToInt32(input.Substring(6, 4)) % 100 != 0 && Convert.ToInt32(input.Substring(6, 4)) % 4 == 0))
                    && (0 > Convert.ToInt32(input.Substring(3, 2)) || Convert.ToInt32(input.Substring(3, 2)) > 29))
                {
                    invalidInput = true;
                }
                // February 
                else if (Convert.ToInt32(input.Substring(0, 2)) == 2 && (0 > Convert.ToInt32(input.Substring(3, 2))
                    || Convert.ToInt32(input.Substring(3, 2)) > 28))
                {
                    invalidInput = true;
                }
                // April, June, September, November
                else if ((Convert.ToInt32(input.Substring(0, 2)) == 4 || Convert.ToInt32(input.Substring(0, 2)) == 6
                    || Convert.ToInt32(input.Substring(0, 2)) == 9 || Convert.ToInt32(input.Substring(0, 2)) == 11)
                    && (0 > Convert.ToInt32(input.Substring(3, 2)) || Convert.ToInt32(input.Substring(3, 2)) > 30))
                {
                    invalidInput = true;
                }
                // January, March, May, July, August, October, December
                else if ((Convert.ToInt32(input.Substring(0, 2)) == 1 || Convert.ToInt32(input.Substring(0, 2)) == 3
                    || Convert.ToInt32(input.Substring(0, 2)) == 5 || Convert.ToInt32(input.Substring(0, 2)) == 7
                    || Convert.ToInt32(input.Substring(0, 2)) == 8 || Convert.ToInt32(input.Substring(0, 2)) == 10
                    || Convert.ToInt32(input.Substring(0, 2)) == 12) && (0 > Convert.ToInt32(input.Substring(3, 2))
                    || Convert.ToInt32(input.Substring(3, 2)) > 31))
                {
                    invalidInput = true;
                }

                // For Time
                else if (!Char.IsDigit(input[11]) || !Char.IsDigit(input[12]) || input[13] != ':'
                    || !Char.IsDigit(input[14]) || !Char.IsDigit(input[15]))
                {
                    invalidInput = true;
                }
                // Hour Range
                else if ((0 > Convert.ToInt32(input.Substring(11, 2)) || Convert.ToInt32(input.Substring(11, 2)) > 23))
                {
                    invalidInput = true;
                }
                // Minute Range
                else if ((0 > Convert.ToInt32(input.Substring(14)) || Convert.ToInt32(input.Substring(14)) > 59))
                {
                    invalidInput = true;
                }
                // Deep Check
                else if ((Convert.ToInt32(dtIN.Substring(0, 2)) > Convert.ToInt32(input.Substring(0, 2))
                    && Convert.ToInt32(dtIN.Substring(6, 4)) == Convert.ToInt32(input.Substring(6, 4)))
                    && (Convert.ToInt32(dtIN.Substring(3, 2)) > Convert.ToInt32(input.Substring(3, 2))
                    && Convert.ToInt32(dtIN.Substring(0, 2)) == Convert.ToInt32(input.Substring(0, 2)))
                    && (Convert.ToInt32(dtIN.Substring(11, 2)) > Convert.ToInt32(input.Substring(11, 2))
                    && Convert.ToInt32(dtIN.Substring(3, 2)) == Convert.ToInt32(input.Substring(3, 2)))
                    && (Convert.ToInt32(dtIN.Substring(14)) > Convert.ToInt32(input.Substring(14))
                    && Convert.ToInt32(dtIN.Substring(11, 2)) == Convert.ToInt32(input.Substring(11, 2))))
                {
                    invalidInput = true;
                }
            }

            return invalidInput;
        }
    }
}
