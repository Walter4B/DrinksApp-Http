using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksApp_Http
{
    internal class Validator
    {
        internal static bool IsStringValid(string stringInput)
        {
            if (String.IsNullOrEmpty(stringInput))
            {
                return false;
            }

            foreach (char c in stringInput)
            {
                if (!Char.IsLetter(c) && c != '/' && c != ' ')
                    return false;
            }

            return true;
        }

        public static bool IsIdValid(string userInput)
        {
            OutputController outputController = new OutputController();

            if (String.IsNullOrEmpty(userInput) || !int.TryParse(userInput, out _))
            {
                outputController.DispalyMessage("Not a number, please try again.");
                return false;
            }

            return true;
        }
    }
}
