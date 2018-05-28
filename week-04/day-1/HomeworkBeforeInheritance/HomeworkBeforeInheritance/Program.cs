using System;
using System.Collections.Generic;

namespace HomeworkBeforeInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Student> students = new List<Student>();
            List<Mentor> mentors = new List<Mentor>();
            List<Sponsor> sponsors = new List<Sponsor>();

            var mark = new Person("Mark", 46, "male");
            people.Add(mark);
            var jane = new Person("Jane Doe", 30, "female");
            people.Add(jane);
            var john = new Student("John Doe", 20, "male", "BME");
            students.Add(john);
            var student = new Student("Jane Doe", 30, "female", "The school of life");
            students.Add(student);
            var gandhi = new Mentor("Gandhi", 148, "male", "senior");
            mentors.Add(gandhi);
            var mentor = new Mentor("Jane Doe", 30, "female", "intermediate");
            mentors.Add(mentor);
            var sponsor = new Sponsor("Jane Doe", 30, "female", "Google");
            sponsors.Add(sponsor);
            var elon = new Sponsor("Elon Musk", 46, "male", "SpaceX");
            sponsors.Add(elon);

            student.SkipDays(3);

            for (int i = 0; i < 5; i++)
            {
                elon.Hire();
            }
            for (int i = 0; i < 3; i++)
            {
                sponsor.Hire();
            }

            foreach (var person in people)
            {
                Console.WriteLine(person.Introduce());
                Console.WriteLine(person.GetGoal());
            }

            foreach (var theStudent in students)
            {
                Console.WriteLine(theStudent.Introduce());
                Console.WriteLine(theStudent.GetGoal());
            }

            foreach (var theMentor in mentors)
            {
                Console.WriteLine(theMentor.Introduce());
                Console.WriteLine(theMentor.GetGoal());
            }

            foreach (var theSponsor in sponsors)
            {
                Console.WriteLine(theSponsor.Introduce());
                Console.WriteLine(theSponsor.GetGoal());
            }
            Console.ReadLine();
        }
    }
}
