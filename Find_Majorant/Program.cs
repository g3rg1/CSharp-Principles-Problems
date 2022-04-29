using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Majorant
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var nums = input.Split(", ").Select(i => int.Parse(i)).ToList();
            nums.Sort();
            var maxCount = 0;
            var len = nums.Count;
            var currentCount = 1;
            int? majorant = null;

            for (int i = 0; i < len - 1; i++)
            {
                if(nums[i] == nums[i+1])
                {
                    currentCount++;
                }
                else 
                {
                    currentCount = 1;
                }

                if (currentCount > maxCount)
                {
                    majorant = nums[i];
                    maxCount = currentCount;
                }
            }

            if (maxCount >= (len/2 + 1))
            {
                Console.WriteLine(majorant);
            }
            else
            {
                Console.WriteLine("Majorant does not exist!");
            }
        }
    }
}
