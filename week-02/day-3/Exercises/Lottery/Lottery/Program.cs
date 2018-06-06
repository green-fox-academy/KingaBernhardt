using System;
using System.Collections.Generic;
using System.IO;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Int32, Int32> lotteryNumberFrequency = new Dictionary<int, int>();
            List<string> lines = new List<string>();
            try
            {
                lines = new List<string>(File.ReadAllLines("lottery.txt"));
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No file found");
            }
            catch (IOException)
            {
                Console.WriteLine("No good");
            }

            foreach(string line in lines)
            {
                int[] numbers = new int[5];
                string[] elements = line.Split(';');
                if (elements.Length > 1)
                {
                    for (int i = elements.Length; i > elements.Length-5; i--)
                    {
                        numbers[Math.Abs(elements.Length - i)] = Int32.Parse(elements[i - 1]);
                    }
                }
                foreach (var currentLottery in numbers)
                {
                    if (!lotteryNumberFrequency.ContainsKey(currentLottery))
                    {
                        lotteryNumberFrequency.Add(currentLottery, 1);
                    }
                    else
                    {
                        lotteryNumberFrequency[currentLottery] += 1;
                    }
                }

                KeyValuePair<int, int> mostCommon = new KeyValuePair<int, int>(0, 0);

                foreach (KeyValuePair<int, int> lottoFreq in lotteryNumberFrequency)
                {
                    if (mostCommon.Value < lottoFreq.Value)
                    {
                        mostCommon = lottoFreq;
                    }
                }
                lotteryNumberFrequency.Remove(mostCommon.Key);
                Console.WriteLine(mostCommon.Key + " : " + mostCommon.Value);
                Console.ReadLine();
            }
        }
    }
}
