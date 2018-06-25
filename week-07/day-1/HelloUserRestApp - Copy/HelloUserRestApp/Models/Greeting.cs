using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloUserRestApp.Models
{
    public class Greeting
    {
        public static int nextId = 0;
        
        public string Content { get; set; }
        public long Id { get;  set; }

        public Greeting(string name)
        {
            Id = nextId++;
            Content = name;
        }
    }
}
