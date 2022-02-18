using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Circle : Shape
    {
        public Circle(double radius)
        {
            this.height = radius;
            this.width = radius;
        }
        public override double CalculateSurface()
        {
            return Math.PI * (this.width * this.height);
        }
        public override string ToString()
        {
            return $"Circle";
        }
    }
}
