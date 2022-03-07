using System;

namespace Quick_Sort
{
    public class QuickSort
    {
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
        public static int[] MixArray(int[] arr)
        {
            int currentIndex = arr.Length;
            int currentValue;
            int randomIndex;
            Random rng = new Random();
            while (currentIndex != 0)
            {
                randomIndex = (int)Math.Floor(rng.NextDouble() * currentIndex);
                currentIndex--;
                currentValue = arr[currentIndex];
                arr[currentIndex] = arr[randomIndex];
                arr[randomIndex] = currentValue;
            }
            return arr;
        }
        static int Partition(int[] arr, int low, int high)
        {
            int temp;
            int pivot = arr[high];

            int i = (low - 1);
            for (int j = low; j <= high - 1; j++)
            {

                if (arr[j] <= pivot)
                {
                    i++;

                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp;

            return i + 1;
        }
        static void QSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                QSort(arr, low, pi - 1);
                QSort(arr, pi + 1, high);
            }
        }
        static void Main(string[] args)
        {
            var arr = GenSortedArray();
            var mixArr = MixArray(arr);
            Console.WriteLine(string.Join(", ", mixArr));
            QSort(mixArr, 0, mixArr.Length - 1);
            Console.WriteLine(string.Join(", ", mixArr));
        }
    }
}
