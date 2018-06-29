using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class GiraffeModel
    {
        public string Name { get; set; }
        public string InputFood { get; set; }
        public string InputDrink { get; set; }
        public string TrickName { get; set; }
        public List<string> Trick = new List<string> { "dance", "sing", "play volleyball", "play the guitar", "hiking", "boxing" };
    }
}
