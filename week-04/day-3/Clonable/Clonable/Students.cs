using System;
using System.Collections.Generic;
using System.Text;

namespace TeachersAndClasses
{
    class Student : ICloneable
    {
        private string name;
        private int age;
        private string gender;
        private string organization;

        public Student(string name, int age, string gender, string organization)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.organization = organization;
        }

        public object Clone()
        {
            Student clonedStudent = new Student(name, age, gender, organization);
            return clonedStudent;
        }

        public string Learn()
        {
            return "There are many types.";
        }

        public string Question(Teacher teacher)
        {
            return teacher.Answer();
        }

        public override string ToString()
        {
            return name + " " + age + " " + gender + " "+ organization;
        }
    }
}
