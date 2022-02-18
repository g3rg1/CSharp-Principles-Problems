using System;

namespace Sum_Of_Elements
{
    class Program
    {
        static void GetNelementSum()
        {
            var n = int.Parse(Console.ReadLine());
            Random rng = new Random();
            int Length = rng.Next(10, 20);
            int[] arr = new int[Length];
            int largestSum = 0;
            for (int i = 0; i < Length; i++)
            {
                arr[i] = rng.Next(-9, 10);
                Console.Write(" {0}", arr[i]);
            }
            Console.WriteLine();

            for (int i = 0; i <= Length - n; i++)
            {
                int currentSum = 0;

                for (int j = i; j < i + n; j++)
                {
                    currentSum += arr[j];
                }

                if (currentSum > largestSum)
                {
                    largestSum = currentSum;
                }
            }
            Console.WriteLine(largestSum);
        }
        static void Main(string[] args)
        {

            GetNelementSum();

        }
    }
}
