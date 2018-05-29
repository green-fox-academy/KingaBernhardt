using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrganization
{
    class Student : Person
    {
        private string previousOrganization;
        private static int skippedDays = 0;

        public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {
            this.previousOrganization = previousOrganization;
        }

        public string GetGoal()
        {
            return "Be a junior software developer.";
        }
        public string Introduce()
        {
            return "Hi, I'm " + Name + " , a " + Age + " year old " + Gender + " who skipped " + skippedDays + " days from the course already.";
        }
        public int SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
            return skippedDays;
        }
    }
}
