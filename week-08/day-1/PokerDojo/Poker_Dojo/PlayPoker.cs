using System;
using System.Collections.Generic;
using System.Text;

namespace Poker_Dojo
{
    public class PlayPoker
    {
        public bool CheckInputLenght(string input)
        {
            string[] temp = input.Split(' ');
           return input.Length == 12;
        }
    }
}
