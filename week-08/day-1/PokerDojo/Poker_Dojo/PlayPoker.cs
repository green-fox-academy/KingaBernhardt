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

        public string GetValue(string input)
        {
            try
            {
                string output = input;
                return output;
            }
            catch (Exception)
            {
                if (input.Equals("J"))
                {
                    return "11";
                }
                else if (input.Equals("D"))
                {
                    return "12";
                }
                else if (input.Equals("K"))
                {
                    return "13";
                }
                else if (input.Equals("A"))
                {
                    return "14";
                }
                return "0";
            }
        }

        public string GetHands(string input)
        {
            string[] raw = input.Split(" ");
            string[] white = new string[5];
            string[] black = new string[5];

            for (int i = 0; i < 5; i++)
            {
                black[i] = raw[i + 1];
                white[i] = raw[i + 7];
            }

            return ("White wins");
        }
    }
}
