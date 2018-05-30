using System;
using System.Collections.Generic;
using System.Text;

namespace Flyable
{
    public abstract class Animal
    {
        protected string name;
        protected int age;

        protected Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int Age
        {
            get
            {
                return age;
            }
        }

        public string GetName()
        {
        return name;
        }

        public abstract string WantChild();
    }
}
