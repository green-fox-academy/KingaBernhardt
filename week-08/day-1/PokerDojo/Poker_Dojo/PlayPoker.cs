using System;
using System.Collections.Generic;
using System.Text;

namespace Poker_Dojo
{
    public class PlayPoker
    {
        public bool CheckInputLenght(string input)
        {
           string[] temp = input.Split(" ");
           return temp.Length == 10;
        }

        public int GetValue(string input)
        {
            try
            {
                int output = Int32.Parse(input);
                return output;
            }
            catch (Exception)
            {
                if (input.Equals("J"))
                {
                    return 11;
                }
                else if (input.Equals("Q"))
                {
                    return 12;
                }
                else if (input.Equals("K"))
                {
                    return 13;
                }
                else if (input.Equals("A"))
                {
                    return 14;
                }
                return 0;
            }
        }
    }
}
