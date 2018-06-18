using System;
using System.Collections.Generic;
using System.Text;

namespace foxLinq
{
    class Fox
    {
        private string name;
        private string color;
        private string type;

        public string Name { get => name; set => name = value; }
        public string Color { get => color; set => color = value; }
        public string Type { get => type; set => type = value; }

        public override string ToString()
        {
            return "The fox what we need: " + Name + " is " + Color +" and it is a "  + Type;
        }
    }
}
