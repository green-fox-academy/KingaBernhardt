using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkBeforeInheritance
{
    class Student
    {
        public string name;
        public int age;
        public string gender;
        public string previousOrganization;
        public int skippedDays;

        public Student(string name, int age, string gender, string previousOrganization)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.previousOrganization = previousOrganization;
            skippedDays = 0;
        }

        public string Introduce()
        {
            return "Hi, I am " + name + " a " + age + " year old " + gender + " from " + previousOrganization + " who skipped " + skippedDays + " days from the course already.";
        }
        public string GetGoal()
        {
            return "My goal is: Be a junior software developer";
        }
        public int SkipDays(int numberOfDays)
        {
            numberOfDays += skippedDays;
            return numberOfDays;
        }
    }
}
