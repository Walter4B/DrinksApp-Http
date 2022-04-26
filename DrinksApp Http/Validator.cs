using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksApp_Http
{
    internal class Validator
    {
        OutputController outputController = new OutputController();

        internal bool ValidateInt(string userInput, int numberOfElements)
        {
            if (string.IsNullOrEmpty(userInput) || !int.TryParse(userInput, out _))
            {
                outputController.DispalyMessage("Not a number, please try again.");
                return false;
            }
            else
            {
                return IsInRange(Convert.ToInt32(userInput), numberOfElements);
            }
        }
        internal bool IsInRange(int input, int numberOfElements)
        {
            if (input <= numberOfElements && input > 0)
            {
                return true;
            }
            else
            {
                outputController.DispalyMessage("Out of Range, please try again.");
                return false;
            }
        }
    }
}
