using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Logs
{
    class Program
    {
        static void Main(string[] args)
        // Read all data from 'log.txt'.
        // Each line represents a log message from a web server
        // Write a function that returns an array with the unique IP adresses.
        // Write a function that returns the GET / POST request ratio.

        {
            foreach (var item in IpAddress("log.txt"))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(Log());
            Console.ReadLine();
        }
        public static string Log()
        {
            int getAmount = 0;
            int postAmount = 0;
            foreach (string line in File.ReadAllLines(@"C:\Users\kinga\OneDrive\Desktop\Green Fox Academy\greenfox\KingaBernhardt\week-02\day-3\Exercises\Logs_core\Logs\log.txt"))
            {
                if (line.Contains("GET"))
                {
                    getAmount++;
                }
                else if (line.Contains("POST"))
                {
                    postAmount++;
                }
            }

            return "The GET and POST ratio is : " + getAmount + "/" + postAmount;
        }

        public static List<string> IpAddress(string path)
        {
            string[] wholeMessages = File.ReadAllLines(@"C:\Users\kinga\OneDrive\Desktop\Green Fox Academy\greenfox\KingaBernhardt\week-02\day-3\Exercises\Logs_core\Logs\log.txt");
            List<string> listOfUniq = new List<string>();

            for (int i = 0; i < wholeMessages.Length; i++)
            {
                wholeMessages[i] = wholeMessages[i].Substring(26, 11);
            
                if (!listOfUniq.Contains(wholeMessages[i]))
                {
                    listOfUniq.Add(wholeMessages[i]);
                }
            }
            return listOfUniq;
        }
    }
}
