using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrganization
{
    class Sponsor : Person
    {
        public string company;
        public int hiredStudents;

        public Sponsor(string name, int age, string gender, string company, int hiredStudents) : base(name, age, gender)
        {
            this.company = company;
            this.hiredStudents = hiredStudents;
        }
    
        public Sponsor()
        {
            company = "Google";
            hiredStudents = 0;
        } 

        public string Introduce()
        {
            return "Hi, I'm " + Name + ", a " + Age + " year old " + Gender + " who represents " + company + " and hired " + Hire() + " students so far.";
        }

        public string GetGoal()
        {
            return "Hire brilliant junior software developers.";
        }

        public int Hire()
        {
            hiredStudents++;
            return hiredStudents;
        }
    }
}
