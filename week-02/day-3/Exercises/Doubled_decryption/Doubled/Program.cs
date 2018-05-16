using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\kinga\OneDrive\Desktop\Green Fox Academy\greenfox\KingaBernhardt\week-02\day-3\Exercises\Doubled_decryption\Doubled\duplicated-chars.txt";
            Decode(path);
        }
        public static void Decode(string path)
        {
            string[] content =
            List<char> chars = new List<char>();
            for (int i=0; i < content.Length; i++)
            {
                for (int j = 0; j < content[i].Length; j++)
                {
                    if (content[i][j] == ' ')
                    {
                        chars.Add(' ');
                    }
                    else
                    {
                        char shiftedChar = (char)((int)content[i][j] - 1);
                        chars.Add(shiftedChar);
                    }
                }
            }
            chars.Add('\n');
        }
    }
}
