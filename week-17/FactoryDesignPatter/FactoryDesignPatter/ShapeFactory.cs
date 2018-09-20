using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPatter
{
    class ShapeFactory
    {
        public Shape GetShape(String shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            else if (shapeType.Equals("Circle"))
            {
                return new Circle();
            }
            else if (shapeType.Equals("Square"))
            {
                return new Square();
            }
            else if (shapeType.Equals("Rectangle"))
            {
                return new Rectangle();
            }
            return null;
        }
    }
}
