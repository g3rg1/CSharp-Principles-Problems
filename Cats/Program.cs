using System;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion testCat = new Lion(true, 100);
            Console.WriteLine("{0}{1}", testCat.Male, testCat.Weight);
        }
    }
}
