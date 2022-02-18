using System;
using System.Collections.Generic;

namespace Selection_Sort
{
    class Program
    {
        static List<int> GetRngList(int get)
        {
            Random rng = new Random();
            List<int> numbers = new List<int>();
            numbers.Add(0);

            while (numbers.Count <= get)
            {
                bool sameNum = false;
                int current = rng.Next(1, get + 1);
                foreach (int num in numbers)
                {
                    if (current == num)
                    {
                        sameNum = true;
                    }
                }
                if (!sameNum)
                {
                    numbers.Add(current);
                }
            }
            return numbers;
        }
        static void SortArr(List<int> arr)
        {
            int tempValue;

            for (int i = 0; i < arr.Count; i++)
            {
                int currSmallest = int.MaxValue;
                int currSmallestIndex = 0;

                for (int j = i; j < arr.Count; j++)
                {
                    if (arr[j] < currSmallest)
                    {
                        currSmallest = arr[j];
                        currSmallestIndex = j;
                    }

                }

                tempValue = arr[i];
                arr[i] = currSmallest;
                arr[currSmallestIndex] = tempValue;
            }
        }

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            List<int> arr = GetRngList(n);

            Console.WriteLine("Before Sorting:");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write($" {arr[i]}");
            }
            Console.WriteLine();
            Console.WriteLine(new string('*', arr.Count * 2 + 1));

            SortArr(arr);

            Console.WriteLine("Sorted:");
            Console.WriteLine(new string('*', arr.Count * 2 + 1));
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write($" {arr[i]}");
            }
        }
    }
}
