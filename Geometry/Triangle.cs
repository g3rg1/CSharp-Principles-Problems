using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Triangle : Shape
    {
        public Triangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double CalculateSurface()
        {
            return (this.width * this.height) / 2;
        }
        public override string ToString()
        {
            return $"Triangle";
        }
    }
}
