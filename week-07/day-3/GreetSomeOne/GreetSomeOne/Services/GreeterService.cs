using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetSomeOne.Services
{
    public class GreeterService : IGreeter
    {
        public string Name { get; set;}
        public string GetName()
        {
            return Name;
        }

        public string SetName(string name)
        {
            return Name = name;
        }

    }
}