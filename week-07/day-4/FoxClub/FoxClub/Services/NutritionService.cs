using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Services
{
    public class NutritionService
    {
        public List<string> PetFoods { get; set; }
        public List<string> PetDrinks { get; set; }

        public List<string> AddNutritions()
        {
            PetFoods.Add("meatball");
            PetFoods.Add("milkrise");
            PetFoods.Add("mashed potato");
            PetFoods.Add("ham and eggs");
            PetFoods.Add("hawai pizza");
            PetFoods.Add("breaded cheese");

            return PetFoods;
        }

        public List<string> AddBeverages()
        {
            PetDrinks.Add("glass of water");
            PetDrinks.Add("juice");
            PetDrinks.Add("glass of beer");
            PetDrinks.Add("english tea");
            PetDrinks.Add("joghurt");
            PetDrinks.Add("wine");

            return PetDrinks;
        }
    }
}
