using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class NutritionStoreModel
    {
        public List<string> PetFoods = new List<string>
        { "meatball", "milkrise", "mashed potato", "ham and eggs", "hawai pizza", "breaded cheese" };

        public List<string> PetDrinks = new List<string>
        { "glass of water", "juice", "glass of beer", "english tea", "joghurt", "wine"};
    }
}
