using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPatter
{
    class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method");
        }
    }
}
