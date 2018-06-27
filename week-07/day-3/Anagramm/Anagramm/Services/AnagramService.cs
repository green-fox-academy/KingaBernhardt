using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagramm.Services
{
    public class AnagramService : IGetAnagram
    {
        public string CheckAnagram(string input, string input2)
        {
            if (input.Length != input2.Length)
            {
                return "Not anagram";
            }
            else if (input == input2)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < input2.Length; j++)
                    {
                        if (input[i] == input2[j])
                        {
                            input2 = " " + input2.Remove(j, 1);
                        }
                        else if (j == input.Length - 1)
                        {
                            return "Not anagrams";
                        }
                    }
                }
            }
            else
            {
                return "Anagram pairs";
            }
            return "Anagram pairs";
        }
    }
}
