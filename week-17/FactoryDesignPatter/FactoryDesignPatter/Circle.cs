using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPatter
{
    class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle:: draw() method");
        }
    }
}
