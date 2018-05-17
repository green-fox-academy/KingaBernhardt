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
            string path = @"C:\Users\kinga\OneDrive\Desktop\Green Fox Academy\greenfox\KingaBernhardt\week-02\day-3\Exercises\Logs_core\Logs\log.txt";
            Console.WriteLine(Log(path));

            foreach (var item in IpAddress(path))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        public static string Log( string logGet)
        {
            int getAmount = 0;
            int postAmount = 0;
            foreach (string line in File.ReadAllLines(logGet))
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

        public static List<string> IpAddress(string IpGet)
        {
            string[] wholeMessages = File.ReadAllLines(IpGet);
            List<string> listOfUniq = new List<string>();

            for (int i = 0; i < wholeMessages.Length; i++)
            {
                wholeMessages[i] = wholeMessages[i].Substring(27, 11);
            
                if (!listOfUniq.Contains(wholeMessages[i]))
                {
                    listOfUniq.Add(wholeMessages[i]);
                }
            }
            return listOfUniq;
        }
    }
}
