using System;
using System.Collections.Generic;

namespace NamespaceImportTest
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string firstDogName = null;
    //        Console.WriteLine("Write first dog name: ");
    //        firstDogName = Console.ReadLine();
    //        Dog firstDog = new Dog(firstDogName);

    //        Dog secondDog = new Dog();
    //        Console.WriteLine("Write second dog name: ");
    //        string secondDogName = Console.ReadLine();
    //        secondDog.Name = secondDogName;

    //        Dog thirdDog = new Dog();

    //        Dog[] dogs = new Dog[] { firstDog, secondDog, thirdDog };

    //        foreach (var dog in dogs)
    //        {
    //            dog.Bark();
    //        }
    //    }
    //}
    class NamespaceImportTest
    {
        static void Main(string[] args)
        {
            //List<int> ints =
            //new List<int>();

            //List<double> doubles =
            //new List<double>();
            //Point point = new Point(1,3);
            //Rectangle rect = new Rectangle(2, 4);
            //var item = new SaleItem("Phasemeter", 100M);
            //while(true)
            //{
            //    int intResult;
            //    double doubleResult;
            //    Console.WriteLine("Enter an int or double:");
            //    string input = Console.ReadLine();
            //    if(int.TryParse(input, out intResult))
            //    {
            //        ints.Add(intResult);
            //    }
            //    else if (double.TryParse(input, out doubleResult))
            //    {
            //        doubles.Add(doubleResult);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //Console.Write("You entered {0} ints: ", ints.Count);
            //foreach (var i in ints)
            //{
            //    Console.Write($" {i}");
            //}
            //Console.WriteLine();

            //Console.Write("You entered {0} doubles: ", doubles.Count);
            //foreach (var d in doubles)
            //{
            //    Console.Write($" {d}");
            //}
            //Console.WriteLine();
            //Console.WriteLine($"co-ords are: x={point.X}, y={point.Y}");
            //Console.WriteLine($"Rectangle sides:{rect.Height},{rect.Width} and area:{rect.Area}");
            //Console.WriteLine($"Item name: {item.Name}, sells for:{item.Cost:C2}");

            Circle circle = new Circle(3);
            circle.PrintSurface();
            //Read page 633;
        }
    }
}
