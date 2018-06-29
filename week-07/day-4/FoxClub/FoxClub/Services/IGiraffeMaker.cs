using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Services
{
    public interface IGiraffeMaker
    {
        string GetName();
        void SetName(string petName);
        void SetDrink(string inputDrink);
        string GetDrink();
        void SetFood(string inputFood);
        string GetFood();
        void SetTrick(string trickName);
        string GetTrick();
        List<string> AddToTrick();
        //int CountTrick(int amountOfTricks);
        //string DoTricks();
        string ToString();
    }
}