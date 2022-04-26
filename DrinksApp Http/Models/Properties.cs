using System;

namespace DrinksApp_Http
{
    internal class RepositoryDrink
    {
        public List<Drink> drinks { get; set; }
    }

    internal class RepositoryCategory
    { 
        public List<CatalogingDrink> drinks { get; set; }
    }

    internal class Drink
    { 
        public string? strDrink { get; set; }
    }

    internal class CatalogingDrink
    {
        public string strCategory { get; set; }
    }
}
