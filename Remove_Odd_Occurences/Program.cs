using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Odd_Occurences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var nums = input.Split(", ").Select(i => int.Parse(i)).ToArray();
            var dict = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if(dict.TryAdd(num, 1))
                {

                }
                else
                {
                    dict[num]++;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if(dict[nums[i]] %2 != 0)
                {
                    continue;
                }
                else
                {
                    Console.Write($" {nums[i]}");
                }
            }
        }
    }
}
