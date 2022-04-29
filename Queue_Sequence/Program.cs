using System;
using System.Collections.Generic;

namespace Queue_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var q = new Queue<int>();
            q.Enqueue(n);
            var count = 1;
            

            Console.WriteLine();
            Console.Write($" {q.Peek()}");

            while (true)
            {
                var currentNum = q.Dequeue();

                var result = currentNum + 1;
                count++;
                q.Enqueue(result);
                Console.Write($" {result}");
                if (count == 50) break;

                result = 2 * currentNum + 1;
                count++;
                q.Enqueue(result);
                Console.Write($" {result}");
                if (count == 50) break;

                result = currentNum + 2;
                count++;
                q.Enqueue(result);
                Console.Write($" {result}");
                if (count == 50) break;
            }
        }
    }
}
