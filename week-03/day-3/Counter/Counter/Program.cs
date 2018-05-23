using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter firstCounter = new Counter();
            int theResult = firstCounter.Add(3);
            firstCounter.Reset();
            firstCounter.Get(theResult);
            Console.WriteLine("This is the number after using the Add method: " + theResult + ".");
            Console.WriteLine("This is the number after reseting the value: " + firstCounter.firstStatus + ".");
            Console.WriteLine("This is the number after using the Get method: " + firstCounter.Get(theResult) + ".");
            Console.ReadLine();
        }
    }
}
