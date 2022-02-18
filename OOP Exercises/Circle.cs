using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceImportTest
{
    class Circle
    {
        public static double PI = 3.141592653589793;
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public static double CalculatgeSurface(double radius)
        {
            return (PI * radius * radius);
        }
        public void PrintSurface()
        {
            double surface = CalculatgeSurface(radius);
            Console.WriteLine($"Circle's Surface is: {surface}");
        }
    }
    
}
