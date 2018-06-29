using FoxClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Services
{
    public class GiraffeService : IGiraffeMaker
    {
        private GiraffeModel giraffeModel;

        public GiraffeService()
        {
            giraffeModel = new GiraffeModel() { Name = "a" };
        }

        public void SetTrick(string trickName)
        {
            giraffeModel.TrickName = trickName;
        }

        public string GetTrick()
        {
            return giraffeModel.TrickName;
        }

        public List<string> AddToTrick()
        {
            giraffeModel.Trick.Add(giraffeModel.TrickName);
            return giraffeModel.Trick;
        }

        /*public string DoTricks()
        {
            for (int i = 0; i < giraffeModel.TheTricks.Count; i++)
            {
                if (giraffeModel.TheTricks == null)
                {
                    return "does not do trick yet";
                }
                else
                {
                    return giraffeModel.TheTricks[i];
                }
            }
            return giraffeModel.TheTricks.ToString();
        }*/

        public string GetDrink()
        {
            return giraffeModel.InputDrink;
        }

        public void SetDrink(string inputDrink)
        {
            giraffeModel.InputDrink = inputDrink;
        }

        public string GetFood()
        {
            return giraffeModel.InputFood;
        }

        public void SetFood(string inputFood)
        {
            giraffeModel.InputFood = inputFood;
        }

        public void SetName(string petName)
        {
            giraffeModel.Name = petName;
        }

        public string GetName()
        {
            return giraffeModel.Name;
        }
    }
}
