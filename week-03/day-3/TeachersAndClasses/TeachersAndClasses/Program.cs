using System;

namespace TeachersAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Teachers teacherName = new Teachers();
            Students studentFirst = new Students();
            Console.WriteLine(studentFirst.Question(teacherName));
            Console.WriteLine(teacherName.Teach(studentFirst));
            Console.ReadLine();
        }
    }
}
