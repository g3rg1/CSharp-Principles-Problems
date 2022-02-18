using System;

namespace Possible_Sum
{
    class Program
    {
        static int[] GenerateArray(int n)
        {
            Random rng = new Random();
            int[] nums = new int[n];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rng.Next(1, 10);
            }
            return nums;
        }
        static int[] GetResult(int n, int s, int[] arr)
        {
            int currentSum = 0;
            int[] resultArr;
            for (int i = 2; i < n; i++)
            {
                resultArr = new int[i];
                for (int e = 0; e < n; e++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        resultArr[j] = arr[j];
                        currentSum += arr[j];
                    }
                }
            }
            return resultArr;
        }
        static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($" {arr[i]}");
            }
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var s = int.Parse(Console.ReadLine());
            int[] arr = GenerateArray(n);
            PrintArr(arr);

        }
    }
}
