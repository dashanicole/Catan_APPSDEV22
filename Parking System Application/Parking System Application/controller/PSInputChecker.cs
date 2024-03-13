using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_System_Application.controller
{
    internal class PSInputChecker
    {
        public bool invalidInputStr(string input)
        {
            bool invalidInput = false;

            // To check if the input is valid or not
            if (input.Length == 0) { invalidInput = true; }
            else
            {
                for (int x = 0; x < input.Length; x++)
                {
                    char ch = input[x];

                    if (Char.IsWhiteSpace(ch)) { invalidInput = true; }
                }
            }

            return invalidInput;
        }

        // Check if the plate number is unique
        public bool checkPltNo(List<string> lst, string pltno)
        {
            for (int x = 0; x < lst.Count; x++)
            {
                if (lst[x].Equals(pltno))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
