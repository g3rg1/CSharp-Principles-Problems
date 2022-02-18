using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading;

namespace Loop_exercises
{
    class Program
    {
        static void PrintTriangle()
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                var num = 1;
                for (int j = 1; j <= i; j++)
                {
                    if (num > 9)
                    {
                        num = 1;
                    }
                    Console.Write($" {num}");
                    num++;
                }
                Console.WriteLine();
            }
        }
        static void GetHappyNums()
        {
            int thousands = 1;
            for (int hundreds = 0; ; hundreds++)
            {
                for (int tens = 0; tens <= 9; tens++)
                {
                    for (int ones = 0; ones <= 9; ones++)
                    {
                        var ab = thousands + hundreds;
                        var cd = tens + ones;
                        if (ab == cd)
                        {
                            Console.WriteLine($"{thousands}{hundreds}{tens}{ones}");
                        }
                    }
                }
                if (hundreds == 9)
                {
                    if (thousands == 9)
                    {
                        break;
                    }
                    hundreds = 0;
                    thousands++;
                }
            }
        }
        static void Getfrom1toN()
        {

            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                    Console.WriteLine(i);
            }
        }
        static void GetSmallAndLargeNum()
        {

            var n = int.Parse(Console.ReadLine());
            int largest = int.MinValue;
            int smallest = int.MaxValue;
            for (int i = 0; i < n; i++)
            {

                var num = int.Parse(Console.ReadLine());
                if (num > largest)
                {
                    largest = num;
                }
                if (num < smallest)
                {
                    smallest = num;
                }
            }
            Console.WriteLine($"Largest:{largest} and Smallest:{smallest}");
        }
        static void GetAllDeckCards()
        {
            string[] suites = { "Hearts", "Clubs", "Spades", "Diamonds" };
            string[] cards = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            for (int suite = 0; suite < 4; suite++)
            {
                for (int card = 0; card < 13; card++)
                {
                    Console.WriteLine($"{cards[card]} of {suites[suite]}");
                }
            }
        }
        static void GetSumFibonacci()
        {

            var n = int.Parse(Console.ReadLine());
            int fibSum = 0;
            int fbn1 = 0;
            int fbn2 = 1;
            int fbnCurrent;
            for (int i = 0; i < n; i++)
            {
                fbnCurrent = fbn2 + fbn1;
                fbn1 = fbn2;
                fbn2 = fbnCurrent;
                fibSum += fbnCurrent;
                Console.WriteLine(fbnCurrent);
            }
            Console.WriteLine(fibSum);
        }
        static void CalatanNums()
        {

            var n = int.Parse(Console.ReadLine());
            BigInteger factorielN = 1;
            BigInteger factorielN2 = 1;
            BigInteger factorielNPlus = 1;
            for (int i = 1; i <= n; i++)
            {
                factorielN *= i;

            }
            Console.WriteLine(factorielN);
            for (int i = 1; i <= 2 * n; i++)
            {
                factorielN2 *= i;
            }
            Console.WriteLine(factorielN2);
            for (int i = 1; i <= n + 1; i++)
            {
                factorielNPlus *= i;
            }
            Console.WriteLine(factorielNPlus);
            BigInteger result = factorielN2 / (factorielNPlus * factorielN);
            Console.WriteLine(result);
        }
        static void CalcFactoriels()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            BigInteger factorielN = 1;
            BigInteger factorielK = 1;
            for (int i = 1; i <= n; i++)
            {
                factorielN *= i;
            }
            for (int i = 1; i <= k; i++)
            {
                factorielK *= i;
            }
            BigInteger result = n * k / (n - k);
            Console.WriteLine($"{result}");
        }
        static void GetPowFactNum()
        {
            var n = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            int pow = 1;
            for (int i = 1; i <= n; i++)
            {
                int factoriel = 1;
                for (int j = 1; j <= i; j++)
                {
                    factoriel *= j;
                }
                Console.WriteLine($"factorial for{i}: {factoriel}");
                pow = (int)(Math.Pow(n, i));
                Console.WriteLine($"Pow for {i}:{pow}");
                result += factoriel / pow;
            }
            Console.WriteLine(result);
        }
        static void DrawNumberRectangle()
        {

            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n + i - 1; j++)
                {
                    Console.Write($"{j}");
                }

                Console.WriteLine();
            }
        }
        static void GetFactorialZeros()
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            string numToCheck = Convert.ToString(factorial);
            int zeroCount = 0;
            for (int i = numToCheck.Length - 1; i >= 0; i--)
            {
                if (numToCheck[i] == '0')
                {
                    zeroCount++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"n!= {factorial}");
            Console.WriteLine($"Ending zeros:{zeroCount}");
        }
        static void ConverToBase()
        {

            Console.WriteLine("Giff int num");
            Console.WriteLine();
            var n = int.Parse(Console.ReadLine());
            var toBin = Convert.ToString(n, 2);
            Console.WriteLine($"{n}to binary is:{toBin}");

            Console.WriteLine(new string('*', 25));

            Console.WriteLine("Giff binary num");
            Console.WriteLine();
            string binary = Console.ReadLine();
            var toDec = Convert.ToInt32(binary, 2);
            Console.WriteLine($"{binary} to decimal is:{toDec}");

            Console.WriteLine(new string('*', 25));

            Console.WriteLine("Giff int num");
            Console.WriteLine();
            var decToHex = int.Parse(Console.ReadLine());
            string toHex = Convert.ToString(decToHex, 16);
            Console.WriteLine($"{decToHex} to Hexadecimal is:{toHex}");

            Console.WriteLine(new string('*', 25));

            Console.WriteLine("Giff Hexadecimal num");
            Console.WriteLine();
            string HextoDec = Console.ReadLine();
            var toDexFromHex = Convert.ToInt32(HextoDec, 16);
        }
        static void RNGFromN()
        {
            var n = int.Parse(Console.ReadLine());
            Random rng = new Random();
            List<int> numbers = new List<int>();
            numbers.Add(0);

            while (numbers.Count <= n)
            {
                bool sameNum = false;
                int current = rng.Next(1, n + 1);
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
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        static void GetGCDAndLCM()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            var gcd = 1;
            for (int i = 1; i <= Math.Sqrt(Math.Max(n, k)); i++)
            {
                if (n % i == 0 && k % i == 0)
                {
                    gcd = i;
                }
            }
            Console.WriteLine(gcd);
            var lcm = Math.Abs(n * k) / gcd;
            Console.WriteLine(lcm);
        }
        static void Main(string[] args)
        {

        }
    }
}