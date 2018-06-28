﻿using FoxClub.Models;
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

        public void SetTrick(string trickName)
        {
            giraffeModel.Trick = trickName;
        }

        public string GetTrick()
        {
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
