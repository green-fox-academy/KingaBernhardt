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
        public string Name { get; set; }

        public void AddTrick(string giveTrick)
        {
            giraffeModel.TheTricks.Add(giveTrick);
        }

        public string DoTricks()
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
        }

        public string Drink()
        {
            return giraffeModel.Drink = "sprite";
        }

        public string Eat()
        {
            return giraffeModel.Food = "hummus";
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}
