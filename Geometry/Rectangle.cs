using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double CalculateSurface()
        {
            return this.width * this.height;
        }
        public override string ToString()
        {
            return $"Rectangle";
        }
    }
}
