using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagramm.Services
{
    public class AnagramService : IGetAnagram
    {
        private bool inputCheck;

        public void CheckAnagram(string input, string input2)
        {
            char[] WordOneArray = input.ToCharArray();
            char[] WordTwoArray = input2.ToCharArray();
            if (WordOneArray.Length != WordTwoArray.Length)
            {
                inputCheck = false;
            }
            else
            {
                Array.Sort(WordOneArray);
                Array.Sort(WordTwoArray);
                inputCheck = WordOneArray.ToString().Equals(WordTwoArray.ToString());
            }
        }

        public string GetMessage()
        {
            if (inputCheck)
            {
                return "This is an anagram pair.";
            }
            else
            {
                return "This is not an anagram pair.";
            }
        }
    }
}
