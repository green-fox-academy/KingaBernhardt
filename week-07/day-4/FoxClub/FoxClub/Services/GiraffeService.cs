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
        private List<string> tricks;

        public void AddTrick(string giveTrick)
        {
            tricks.Add(giveTrick);
        }

        public string DoTricks(List<string> trickInput)
        {
            for (int i = 0; i < tricks.Count; i++)
            {
                if (tricks == null)
                {
                    return "does not do trick yet";
                }
                else
                {
                    return tricks[i];
                }
            }
            return trickInput.ToString();
        }


        public string Drink()
        {
            return giraffeModel.Drink = "sprite";
        }

        public string Eat()
        {
            return giraffeModel.Food = "hummus";
        }

        
    }
}
