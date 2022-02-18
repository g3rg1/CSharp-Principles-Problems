using System;
using System.Collections.Generic;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            List<Shape> shapes = new List<Shape>();
            for (int i = 0; i < 10; i++)
            {
                shapes.Add(new Shape());
                var shape = new Shape();
                int figure = rng.Next(0, 3);
                int width = rng.Next(5, 21);
                int height = rng.Next(5, 21);
                switch (figure)
                {
                    case 0:
                        {
                            shape = new Triangle(width, height);
                            
                        }
                        break;
                    case 1:
                        {
                            shape = new Rectangle(width, height);
                        }
                        break;
                    case 2:
                        {
                            shape = new Circle(width);
                        }
                        break;
                }
                shapes[i] = shape;
            }
            double[] faces = new double[shapes.Count];
            for (int i = 0; i < shapes.Count; i++)
            {
                faces[i] = shapes[i].CalculateSurface();
                Console.WriteLine($"{i}, {shapes[i]}, {faces[i]:f2}");
            }
        }
    }
}
