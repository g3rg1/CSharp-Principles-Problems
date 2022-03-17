using System;

namespace Print_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n:D}".PadLeft(15));
            Console.WriteLine($"{n:X}".PadLeft(15));
            Console.WriteLine($"{n:P}".PadLeft(15));
            Console.WriteLine($"{n:C}".PadLeft(15));
            Console.WriteLine($"{n:E}".PadLeft(15));
        }
    }
}
