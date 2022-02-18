using System;

namespace Nested_Loops
{
    class Program
    {
        static int numberOfLoops;
        static int fromToNums;
        static int[] loops;
        static void NestedLoops(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintLoops();
                return;
            }
            for (int i = 0; i < fromToNums; i++)
            {
                loops[currentLoop] = i;
                NestedLoops(currentLoop + 1);
            }
        }
        static void PrintLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write($"{loops[i]} ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            numberOfLoops = int.Parse(Console.ReadLine());
            fromToNums = int.Parse(Console.ReadLine());
            loops = new int[numberOfLoops];
            NestedLoops(0);
        }
    }
}
