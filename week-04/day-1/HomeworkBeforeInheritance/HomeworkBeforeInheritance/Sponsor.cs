using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkBeforeInheritance
{
    class Sponsor
    {
        public string name;
        public int age;
        public string gender;
        public string company;
        public int hiredStudent;

        public Sponsor(string name, int age, string gender, string company)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.company = company;
            hiredStudent = 0;
        }
        public string Introduce()
        {
            return "Hi, I am " + name + " a " + age + " year old " + gender + " who represents " + company + " and hired" + hiredStudent + " students so far.";
        }
        public int Hire()
        {
            hiredStudent++;
            return hiredStudent;
        }
        public string GetGoal()
        {
            return "Hire brilliant junior software developers.";
        }
    }
}
