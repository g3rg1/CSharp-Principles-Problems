using System;

namespace Number_Range_Exeption
{
    class Program
    {
        static void ReadNumber(int start, int end, int n)
        {
            var nums = new int[n];
            var currentNum = start;
            try
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Enter a number, larger than {currentNum}");
                    var num = int.Parse(Console.ReadLine());
                    if (num > currentNum && num < end)
                    {
                        nums[i] = num;
                        currentNum = num;
                    }
                    else
                    {
                        throw
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many nums to enter:");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a staring num:");
            var start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a ending num:");
            var end = int.Parse(Console.ReadLine());
            
        }
    }
}
