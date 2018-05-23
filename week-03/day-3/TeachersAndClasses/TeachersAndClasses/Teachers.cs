using System;
using System.Collections.Generic;
using System.Text;

namespace TeachersAndClasses
{
    class Teachers
    {
        public string Teach(Students student)
        {
            return student.Learn();
        }
        public string Answer()
        {
            return "Please tell me two type of trees!";
        }
    }
}
