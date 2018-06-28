using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Services
{
    public interface IGiraffeMaker
    {
        void AddTrick(string giveTrick);
        string DoTricks(List<string> trickInput);
        int CountTricks(List<string> trickInput);
        string ToString();
        string Eat();
        string Drink();
    }
}
