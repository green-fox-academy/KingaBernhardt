using System;
using System.Collections.Generic;
using System.IO;

namespace FreqWords
{
    class Program
    {
        public static void Main(string[] args)
        {
            //1. Write the selectWordsByFrequency method to find the needed words
            List<string> selectedWords = SelectWordsByFrequency("input.txt", 2);

            //2. Write the saveSelectedWords method to save the selected words
            SaveSelectedWords("output.txt", selectedWords);
            Console.ReadLine();
        }

        private static void SaveSelectedWords(string v, List<string> selectedWords)
        {
            StreamWriter intoNewFile = new StreamWriter(v);
            foreach (var item in selectedWords)
            {
                intoNewFile.WriteLine(item);
            }
        }

        private static List<string> SelectWordsByFrequency(string v1, int v2)
        {
            List<string> lines = new List<string>();
            string[] words = { };
            Dictionary<string, int> wordsFreq = new Dictionary<string, int>();

            try
            {
                foreach (string line in File.ReadAllLines(v1))
                {
                    lines.Add(line);
                }
                
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not exist");
            }

            List<string> needWords = new List<string>();
            foreach(var partLines in lines)
            {
                string[] word = partLines.Split(" ");
                for (int i= 0; i < words.Length; i++)
                {
                    needWords.Add(words[i]);
                }
            }

            foreach (var word in needWords)
            {
                if (!wordsFreq.ContainsKey(word))
                {
                    wordsFreq[word] = 1;
                }
                else
                {
                    wordsFreq[word] += 1;
                }
            }

            List<string> currentWords = new List<string>();
            foreach (var item in wordsFreq)
            {
                if (item.Value == v2)
                {
                    currentWords.Add(item.Key);
                }
            }
            return currentWords;
        }
    }
}
