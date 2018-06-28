using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Services
{
    public interface IGiraffeMaker
    {
        string GetName();
        void SetName(string name);
        void SetDrink(string inputDrink);
        string GetDrink();
        void SetFood(string inputFood);
        string GetFood();
        string SetTrick(string trickName);
        int CountTrick(int amountOfTricks);
        string DoTricks();
        string ToString();
    }
}