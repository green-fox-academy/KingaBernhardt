using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class GiraffeModel
    {
        public string InputFood { get; set; }
        public string InputDrink { get; set; }
        public List<string> PetFoods { get; set; }
        public List<string> PetDrinks { get; set; }
        public string Trick {get;set;}
    }
}
