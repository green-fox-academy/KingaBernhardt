using FoxClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Services
{
    public class NutritionService
    {
        private GiraffeModel giraffe;
        private NutritionStoreModel nutritionStoreModel;

        public NutritionService()
        {
            giraffe = new GiraffeModel() { };
            nutritionStoreModel = new NutritionStoreModel() { };
        }       

        public List<string> AddNutritions()
        {
            nutritionStoreModel.PetFoods.Add(giraffe.InputFood);
            return nutritionStoreModel.PetFoods;
        }

        public List<string> AddBeverages()
        {
            nutritionStoreModel.PetDrinks.Add(giraffe.InputDrink);
            return nutritionStoreModel.PetDrinks;
        }
    }
}
