using System;

namespace TeachersAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Teachers missKinga = new Teachers();
            Students alex = new Students();
            Console.WriteLine(alex.Question(missKinga));
            Console.WriteLine(missKinga.Teach(alex));
            Console.ReadLine();
        }
    }
}
