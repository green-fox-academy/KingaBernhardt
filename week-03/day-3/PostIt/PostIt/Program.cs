using System;

namespace PostIt
{
    class Program
    {
        static void Main(string[] args)
        {
            PostIt postItFirst = new PostIt("orange", "Idea 1", "blue");
            PostIt postItSecond = new PostIt("pink", "Awesome", "black");
            PostIt postItThird = new PostIt("yellow", "Superb", "green");
            Console.WriteLine("Here is an " + postItFirst.backgroundcolor + " postIt with " + postItFirst.text + " text on it which is " + postItFirst.textColor + ".");
            Console.ReadLine();
        }
    }
}
