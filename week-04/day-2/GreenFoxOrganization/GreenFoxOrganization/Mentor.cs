using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrganization
{
    class Mentor : Person
    {
        public string level;

        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.level = level;
        }

        public Mentor()
        {
            level = "intermediate";
        }

        public string GetGoal()
        {
            return "Educate brilliant junior software developers.";
        }
        public string Introduce()
        {
            return "Hi, I'm " + Name + ", a " + Age + " year old " + Gender + " " + level + " mentor.";
        }
    }
}
