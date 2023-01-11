using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksApp_Http
{
    public class InputController
    {
        HttpManager httpManager = new();
        OutputController outputController = new OutputController();

        internal void InputGetCategories()
        {
            var categories = httpManager.GetCategories();
            outputController.DispalyMessage("Choose category:");

            string category = Console.ReadLine();

            while (!Validator.IsStringValid(category))
            {
                outputController.DispalyMessage("\nInvalid category");
                category = Console.ReadLine();
            }

            if (!categories.Any(x => x.strCategory == category))
            {
                outputController.DispalyMessage("Category doesn't exist.");
                InputGetCategories();
            }

            InputGetDrinks(category);
        }

        private void InputGetDrinks(string category)
        {
            var drinks = httpManager.GetDrinksByCategory(category);
            outputController.DispalyMessage("Choose a drink or go back to category menu by typing 0:");

            string drink = Console.ReadLine();

            if (drink == "0") InputGetCategories();

            while (!Validator.IsIdValid(drink))
            {
                outputController.DispalyMessage("\nInvalid drink");
                drink = Console.ReadLine();
            }

            if (!drinks.Any(x => x.idDrink == drink))
            {
                outputController.DispalyMessage("Drink doesn't exist.");
                InputGetDrinks(category);
            }


            httpManager.GetDrink(drink);

            outputController.DispalyMessage("Press any key to go back to categories menu");
            Console.ReadKey();
            if (!Console.KeyAvailable) InputGetCategories();

        }
    }
}
