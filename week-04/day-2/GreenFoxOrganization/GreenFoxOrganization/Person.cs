using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrganization
{
    class Person
    {
        private string name;
        private int age;
        private string gender;

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
        }
        public Person()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
        }
        public string Introduce()
        {
            return "Hi, I'm " + name + " , a " + age + " year old " + gender + ".";
        }
        public string GetGoal()
        {
            return "My goal is: Live for the moment!";
        }
    }
}
