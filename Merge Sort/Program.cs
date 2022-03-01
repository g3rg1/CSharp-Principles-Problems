using Binary_Search;
using System;

namespace Merge_Sort
{
    class MergeSort : BinarySearcher
    {
        static int[] MixArray(int[] arr)
        {
            int currentIndex = arr.Length;
            int currentValue;
            int randomIndex;
            Random rng = new Random();
            while(currentIndex != 0)
            {
                randomIndex = (int)Math.Floor(rng.NextDouble() * currentIndex);
                currentIndex--;
                currentValue = arr[currentIndex];
                arr[currentIndex] = arr[randomIndex];
                arr[randomIndex] = currentValue;
            }
            return arr;
        }
        public static void Merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] arrL = new int[n1];
            int[] arrR = new int[n2];
            int i, j;
            for (i = 0; i < n1; i++)
            {
                arrL[i] = arr[l + i];
            }
            for (j = 0; j < n2; j++)
            {
                arrR[i] = arr[m + 1 + j];
            }
            i = 0;
            j = 0;
            int k = l;
            while (i < n1 && j < n2)
            {
                if (arrL[i] <= arrR[j])
                {
                    arr[k] = arrL[i];
                    i++;
                }
                else
                {
                    arr[k] = arrR[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = arrL[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = arrR[j];
                j++;
                k++;
            }
        }
        public static void Sort(int[] arr, int l, int r)
        {
            if (r < l)
            {
                int m = l + (r - 1) / 2;
                Sort(arr, l, m);
                Sort(arr, m + 1, r);
                Merge(arr, l, m, r);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = GenSortedArray();
            PrintArr(arr);
            int[] mixedArr = MixArray(arr);
            PrintArr(mixedArr);
            Sort(mixedArr, 0, mixedArr.Length - 1);
            PrintArr(mixedArr);
        }
    }
}
