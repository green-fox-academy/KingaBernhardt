using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkBeforeInheritance
{
    class Mentor
    {
        public string name;
        public int age;
        public string gender;
        public string level;

        public Mentor(string name, int age, string gender, string level)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.level = level;
        }
        public string Introduce()
        {
            return "Hi, I am " + name + " a " + age + " year old " + gender +level+ " mentor.";
        }
        public string GetGoal()
        {
            return "Educate brilliant junior software developers.";
        }
    }
}
