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
            input = String.Concat(input.OrderBy(c => c));
            input2 = String.Concat(input2.OrderBy(c => c));

            if (input == input2)
            {
                inputCheck = true;
            }
            else
            {
                inputCheck = false;
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
