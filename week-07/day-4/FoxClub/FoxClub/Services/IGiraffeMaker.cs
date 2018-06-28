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
        void AddTrick(string giveTrick);
        string DoTricks();
        string ToString();
        string Eat();
        string Drink();
    }
}