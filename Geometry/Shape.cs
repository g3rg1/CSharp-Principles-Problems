using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Shape
    {
        protected double width = 0;
        protected double height = 0;

        public virtual double CalculateSurface()
        {
            var result = width * height;
            return result;
        }
    }
}
