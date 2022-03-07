using System;
using System.Collections.Generic;

namespace Prime_Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            bool isPrime = true;
            var primes = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                for (int j = 2; j <= n; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    primes.Add(i);
                }
                isPrime = true;
            }
            foreach (var prime in primes)
            {
                Console.Write($" {prime}");
            }
        }
    }
}
