using System;

namespace GreenFoxOrganization
{
    class Program
    {
        static void Main(string[] args)
        {
            Student jane = new Student("Jane Doe", 30, "female", "The school of life");
            Console.WriteLine(jane.Introduce());
            Student anna = new Student("Bence", 25, "male", "The school of life");
            Student nori = new Student("Nori", 28, "female", "Working hard");
            Student kinga = new Student("Kinga", 24, "female", "Working in London");
            kinga.SkipDays(12);
            Console.WriteLine(kinga.Introduce());
            Console.WriteLine(nori.GetGoal());
            Mentor janeMentor = new Mentor();
            Mentor mark = new Mentor();
            Mentor levi = new Mentor();
            Mentor laci = new Mentor();
            Console.WriteLine(janeMentor.Introduce());
            Console.WriteLine(laci.GetGoal());
            Sponsor janeSponsor = new Sponsor();
            Console.WriteLine(janeSponsor.Introduce());
            Console.WriteLine(janeSponsor.Hire());
            Sponsor bestByte = new Sponsor();
            Sponsor prezi = new Sponsor();
            Console.WriteLine(prezi.Hire());
            Cohort bestCohort = new Cohort("fulvipes");
            bestCohort.AddMentor(mark);
            bestCohort.AddMentor(levi);
            bestCohort.AddMentor(laci);
            bestCohort.AddMentor(janeMentor);

            bestCohort.AddStudent(jane);
            bestCohort.AddStudent(anna);
            bestCohort.AddStudent(nori);
            bestCohort.AddStudent(kinga);

            Console.WriteLine(bestCohort.Info());
            Console.ReadLine();
        }
    }
}
