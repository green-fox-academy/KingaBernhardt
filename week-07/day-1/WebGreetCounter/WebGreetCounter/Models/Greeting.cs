using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloUserRestApp.Models
{
    public class Greeting
    {
        public long id;
        public static int nextId = 0;

        public Greeting(string content)
        {
            id = nextId++;
            Content = content;
        }

        public string Content { get; set; }
    }
}
