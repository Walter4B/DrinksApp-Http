using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace DrinksApp_Http
{
    public class Program
    {
        static void Main(string[] args)
        {
            InputController inputController = new InputController();
            inputController.InputGetCategories();
        }
    }
}
