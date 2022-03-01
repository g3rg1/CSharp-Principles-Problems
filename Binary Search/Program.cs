using System;

namespace Binary_Search
{
    public class BinarySearcher
    {
        /// <summary>
        /// This method generates a pseudo-random sorted array.
        /// </summary>
        public static int[] GenSortedArray()
        {
            Random rng = new Random();
            int[] arr = new int[rng.Next(11, 15)];
            int value = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                value += rng.Next(2, 5);
                arr[i] = value;
            }
            return arr;
        }
        static string BinarySearch(int[] arr, int n)
        {
            int firstIndex = 0;
            int lastIndex = arr.Length-1;
            while (firstIndex <= lastIndex)
            {
                int halfWayIndex = (firstIndex + lastIndex) / 2;

                if (n == arr[halfWayIndex])
                {
                    return $"[{halfWayIndex}] ";
                }
                else if (n < arr[halfWayIndex])
                {
                    lastIndex = halfWayIndex - 1;
                }
                else
                {
                    firstIndex = halfWayIndex + 1;
                }
            }
            return "Not present.";
            
        }
        public static void PrintArr(int[]arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] arr = GenSortedArray();
            //int[] arr = new int[11] { 4, 7, 11, 14, 16, 20, 22, 24, 28, 31, 33 };
            PrintArr(arr);
            object awnser = BinarySearch(arr, n);
            Console.WriteLine(awnser);
        }
    }
}
