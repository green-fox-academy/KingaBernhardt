using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPatter
{
    class Square : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square:: draw() method");
        }
    }
}
