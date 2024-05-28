using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ParkingSystemDesign.controller
{
    internal class InputChecker
    {
        //public bool invalidInputStr(string input)
        //{
        //    bool invalidInput = false;

        //    // To check if the input is valid or not
        //    if (input.Length == 0) { invalidInput = true; }
        //    else
        //    {
        //        for (int x = 0; x < input.Length; x++)
        //        {
        //            char ch = input[x];

        //            if (Char.IsWhiteSpace(ch)) { invalidInput = true; break; }
        //        }
        //    }

        //    // Regex pattern to match all special characters except dash (-)
        //    string pattern = @"[!\""#\$%&'()*+,./:;<=>?@[\\]^_`{|}~]";
        //    MatchCollection matches = Regex.Matches(input, pattern);

        //    foreach (Match match in matches)
        //    {
        //        invalidInput = true;
        //        break;
        //    }

        //    return invalidInput;
        //}

        public bool invalidInputStr(string input)
        {
            // Return true if the input is empty
            if (string.IsNullOrWhiteSpace(input))
            {
                return true;
            }

            // Regex pattern to match any whitespace or special characters except dash (-)
            string pattern = @"[\s!\""#\$%&'()*+,./:;<=>?@[\\\]^_`{|}~]";
            return Regex.IsMatch(input, pattern);
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
