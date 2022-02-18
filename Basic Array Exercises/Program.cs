using System;
using System.Collections.Generic;

namespace Basic_Array_Exercises
{
    class Program
    {

        static void FindSameNums()
        {

            Random rng = new Random();
            int Length = rng.Next(10, 20);
            int[] arr = new int[Length];

            int maxsameNum = 0;
            int vip = 0;
            for (int i = 0; i < Length; i++)
            {
                arr[i] = rng.Next(1, 10);
                Console.Write(" {0}", arr[i]);
            }
            Console.WriteLine();
            for (int elementToCheck = 0; elementToCheck < arr.Length; elementToCheck++)
            {
                int sameNumCounter = 0;
                int current = arr[elementToCheck];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == current)
                    {
                        continue;
                    }

                    if (arr[i] == current)
                    {
                        sameNumCounter++;
                    }
                }

                if (sameNumCounter > maxsameNum)
                {
                    vip = current;
                    maxsameNum = sameNumCounter;
                }
            }
            Console.WriteLine($"{vip}, encountered {maxsameNum} times.");
        }
        static void GetNelementSum()
        {
            var n = int.Parse(Console.ReadLine());
            Random rng = new Random();
            int Length = rng.Next(10, 20);
            int[] arr = new int[Length];
            int largestSum = 0;
            for (int i = 0; i < Length; i++)
            {
                arr[i] = rng.Next(1, 5);
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
        static void GetStolenSolution()
        {
            int counter = 0, tempIndex, tempCounter;
            Random rng = new Random();
            int length = rng.Next(10, 16);

            int[] arr = new int[length];
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = rng.Next(1, 10);
                Console.Write(arr[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < length; i++)
            {
                int[] tempResult = new int[length];
                tempIndex = tempCounter = 1;
                tempResult[0] = arr[i];

                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] > tempResult[tempIndex - 1])
                    {
                        tempResult[tempIndex] = arr[j];
                        tempIndex++;
                        tempCounter++;
                    }
                    else if (tempIndex > 1 && arr[j] > tempResult[tempIndex - 2] && arr[j] < tempResult[tempIndex - 1])
                    {
                        tempResult[tempIndex - 1] = arr[j];
                    }
                }

                if (counter < tempCounter)
                {
                    counter = tempCounter;
                    result = tempResult;
                }
            }

            for (int i = 0; i < counter; i++)
            {
                Console.Write("{0},", result[i]);
            }
        }
        static void GetFirstIncreasingNums()
        {
            Random rng = new Random();
            int[] array = new int[rng.Next(10, 31)];
            string current = "";
            string currentLongest = "";
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rng.Next(1, 10);
                Console.Write(" {0}", array[i]);
            }
            int[] tempArray = array;
            int currentElement;
            for (int i = 0; i < array.Length - 1; i++)
            {
                current = "";
                tempArray = array;
                currentElement = array[i];
                for (int j = i + 1; j < array.Length - 1; j++)
                {
                    //if(currentElement<tempArray[j])

                }
            }
            Console.WriteLine();
            Console.WriteLine(new string('*', current.Length));
            Console.WriteLine(current);
        }
        static void GetFirstIncreasingNums2()
        {
            Random rng = new Random();
            int[] array = new int[rng.Next(10, 31)];
            string current = "";
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rng.Next(1, 10);
                Console.Write(" {0}", array[i]);
            }
            for (int i = 0; i < array.Length - 1; i++)
            {

                if (array[i] < array[i + 1])
                {
                    if (current == "")
                    {
                        current += array[i] + "" + array[i + 1];
                    }
                    else
                    {
                        current += array[i + 1];
                    }
                }
                else if (current == "")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine(new string('*', current.Length));
            Console.WriteLine(current);
        }
        static void GetConsecutiveNums()
        {
            Random rng = new Random();
            int[] array = new int[rng.Next(10, 21)];
            string longest = "";
            string current = "";
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rng.Next(1, 5);
                Console.Write(" {0}", array[i]);
            }
            current = Convert.ToString(array[0]);
            for (int i = 0; i < array.Length - 1; i++)
            {

                if (array[i] == array[i + 1] - 1)
                {
                    current += array[i + 1];

                    if (current.Length > longest.Length)
                    {
                        longest = current;
                    }
                }
                else
                {
                    current = Convert.ToString(array[i + 1]);
                }

            }
            Console.WriteLine();
            Console.WriteLine(new string('*', longest.Length));
            Console.WriteLine(longest);
        }
        static void GetLongestStreak()
        {
            Random rng = new Random();
            int[] array = new int[rng.Next(10, 21)];
            string longest = "";
            string current = "";
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rng.Next(1, 6);
                Console.Write(" {0}", array[i]);
            }
            current = Convert.ToString(array[0]);
            for (int i = 0; i < array.Length - 1; i++)
            {

                if (array[i] == array[i + 1])
                {
                    current += array[i + 1];

                    if (current.Length > longest.Length)
                    {
                        longest = current;
                    }
                }
                else
                {
                    current = Convert.ToString(array[i + 1]);
                }

            }
            Console.WriteLine();
            Console.WriteLine(new string('*', longest.Length));
            Console.WriteLine(longest);
        }
        static void GetLexArray()
        {
            Random rng = new Random();
            byte first = 0;
            char[] array1 = new char[rng.Next(1, 25)];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = (char)rng.Next(97, 123);
            }
            char[] array2 = new char[rng.Next(1, 25)];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = (char)rng.Next(97, 123);
            }
            Console.WriteLine("First array:");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($" {array1[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("Second array:");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($" {array2[i]}");
            }
            Console.WriteLine();
            for (int i = 0; i < Math.Max(array1.Length, array2.Length); i++)
            {
                if (array1[i] == array2[i])
                {
                    continue;
                }
                else if (array1[i] > array2[i])
                {
                    first = 2;
                    break;
                }
                else
                {
                    first = 1;
                    break;
                }
            }
            if (array1.Length == array2.Length && first == 0)
            {
                Console.WriteLine("arrays are tied");
            }
            else if (first == 1)
            {
                Console.WriteLine("first array is earlyer");
            }
            else
            {
                Console.WriteLine("second array is earlyer");
            }
        }
        static void CheckArrays()
        {
            Console.WriteLine("first array lenght:");
            var n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("second array lenght:");
            var n2 = int.Parse(Console.ReadLine());

            int[] array1 = new int[n1];
            int[] array2 = new int[n2];
            bool same = true;
            Console.WriteLine("input first array elements:");
            for (int i = 0; i < n1; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("input second array elements:");
            for (int i = 0; i < n2; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            if (array1.Length == array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] != array2[i])
                    {
                        same = false;
                        break;
                    }
                }
            }
            else
            {
                same = false;
            }
            Console.WriteLine(same ? "Arrays are same" : "Arrays are different");
        }
        static void FillArray()
        {

            var n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i * 5;
            }
            foreach (var item in array)
            {
                Console.Write(" {0,3}", item);
            }
        }
        static void DrawPascalTriangle()
        {

            var height = int.Parse(Console.ReadLine());
            long[][] triangle = new long[height + 1][];
            for (int row = 0; row < height; row++)
            {
                triangle[row] = new long[row + 1];
            }
            triangle[0][0] = 1;
            for (int row = 0; row < height - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }

            for (int row = 0; row < height; row++)
            {
                Console.Write(" ".PadLeft((height - row) * 2));
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("{0,3} ", triangle[row][col]);
                }
                Console.WriteLine();
            }
        }
        static void Sum2x2SubMatrix()
        {
            Console.WriteLine("Size in rows?");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine("Size in columbs?");
            var y = int.Parse(Console.ReadLine());
            int[,] matrix = new int[x, y];
            Random rng = new Random();
            int largSum = int.MinValue;
            for (int row = 0; row < x; row++)
            {
                for (int col = 0; col < y; col++)
                {
                    matrix[row, col] = rng.Next(1, 3);
                }
            }
            for (int row = 0; row < x; row++)
            {
                for (int col = 0; col < y; col++)
                {
                    Console.Write($" {matrix[row, col]}");
                }
                Console.WriteLine();
            }
            for (int row = 0; row < x - 1; row++)
            {
                for (int col = 0; col < y - 1; col++)
                {
                    var current = matrix[row, col] + matrix[row, col + 1]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (current > largSum)
                    {
                        largSum = current;
                    }
                }
            }
            Console.WriteLine("Largest 2x2 submatrix is:{0}", largSum);

        }
        static void Main(string[] args)
        {
            //DrawPascalTriangle();
            //FillArray();
            //CheckArrays();
            //GetLexArray();
            //GetLongestStreak();
            //GetConsecutiveNums();
            //GetFirstIncreasingNums();
            //GetStolenSolution();
            //GetNelementSum();
            //FindSameNums();
        }
    }
}
