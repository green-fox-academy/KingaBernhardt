using System;
using System.Collections.Generic;
using System.Text;

namespace TeachersAndClasses
{
    class Teacher
    {
        public string Teach(Student student)
        {
            return student.Learn();
        }

        public string Answer()
        {
            return "Please tell me two type of trees!";
        }
    }
}
