using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkBeforeInheritance
{
    class Person
    {
        public string name;
        public int age;
        public string gender;

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public string Introduce()
        {
            return "Hi, I am " + name + " a " + age + " year old " + gender + ".";
        }
        public string GetGoal()
        {
            return "My goal is: Live for moment.";
        }
    }
}
