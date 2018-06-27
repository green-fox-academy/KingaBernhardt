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
            char[] temp = input.ToCharArray();
            Array.Reverse(temp);
            string anagramm = string.Join("", temp);

            inputCheck = anagramm == input2;
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
