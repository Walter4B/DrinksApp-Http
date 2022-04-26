using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksApp_Http
{
    internal class InputController
    {
        Validator validator = new Validator();

        internal int GetInputIntValidateInRange(int numberOfElements)
        {
            string userInput = Console.ReadLine();

            while (!validator.ValidateInt(userInput, numberOfElements))
            {
                userInput = Console.ReadLine();
            }

            int userInputValidInt = Convert.ToInt32(userInput);
            return userInputValidInt;
        }
    }
}
