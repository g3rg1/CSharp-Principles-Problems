using System;
using System.Collections.Generic;

namespace Reverse_Order
{
    class Program
    {
        static string GenNums()
        {
            var rng = new Random();
            var input = "";
            for (int i = 0; i < rng.Next(5, 10); i++)
            {
                input += $" {rng.Next(2, 20)}";
            }
            return input;
        }
        static void Main(string[] args)
        {
            var input = GenNums();
            Console.WriteLine(input);

            var stack = new Stack<string>();
            var nums = input.Split(' ');

            for (int i = 0; i < nums.Length; i++)
            {
                stack.Push(nums[i]);
            }

            Console.WriteLine();

            while (stack.Count > 0)
            {
                Console.Write($" {stack.Pop()}");
            }
        }
    }
}
