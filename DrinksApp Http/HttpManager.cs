using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace DrinksApp_Http
{
    internal class HttpManager
    {
        private static readonly HttpClient httpClient = new HttpClient();

        internal static Task run()
        {
            return ProcessRepositories();
        }

        private static async Task ProcessRepositories()
        {
            TableVisualisationEngine dataDisplayEngine = new TableVisualisationEngine();
            OutputController outputController = new OutputController();
            InputController inputController = new InputController();

            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var streamTaskCategories = httpClient.GetStreamAsync("https://www.thecocktaildb.com/api/json/v1/1/list.php?c=list");
            var repoCategories = await JsonSerializer.DeserializeAsync<RepositoryCategory>(await streamTaskCategories); //Gets all categories

            List<List<object>> listOfCategories = new List<List<object>>();

            int keyInt = 1;
            foreach (var element in repoCategories.drinks)
            {
                string number = Convert.ToString(keyInt);
                listOfCategories.Add(new List<object> { number, element.strCategory });
                keyInt++;
            }

            dataDisplayEngine.DisplayDataInTable(listOfCategories, "Categoryes");

            outputController.DispalyMessage("Please choose a category");
            int input = inputController.GetInputIntValidateInRange(listOfCategories.Count);

            string pathStringCategory = Convert.ToString(listOfCategories[input - 1][1]);
            pathStringCategory = pathStringCategory.Replace(" ", "_");
            string pathString = "https://www.thecocktaildb.com/api/json/v1/1/filter.php?c=" + $"{pathStringCategory}";

            var streamTaskDrinks = httpClient.GetStreamAsync(pathString);
            var repoDrinks = await JsonSerializer.DeserializeAsync<RepositoryDrink>(await streamTaskDrinks); //Gets all drinks in a category

            List<object> drinksInCategory = new List<object>();

            foreach (var element in repoDrinks.drinks)
            {
                drinksInCategory.Add(element.strDrink);
            }

            dataDisplayEngine.DisplayDataInTable(drinksInCategory, "Drinks");
        }
    }

}
