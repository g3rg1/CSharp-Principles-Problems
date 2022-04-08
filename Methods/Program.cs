using System;
using System.Linq;

namespace Methods
{
    class Program : TaskMethods
    {
        static void Main(string[] args)
        {
            var m = new TaskMethods();
            PrintInfo();
            while (true)
            {
                var command = Console.ReadLine();
                if (command.ToLower() == "exit")
                {
                    break;
                }

                switch (command.ToLower())
                {
                    case "info":
                        PrintInfo();
                        break;
                    case "clear":
                        Console.Clear();
                        PrintInfo();
                        break;
                    case "1":
                        FirstTask(m);
                        break;
                    case "2":
                        SecondTask(m);
                        break;
                    case "3":
                        ThirdTask(m);
                        break;
                    case "4":
                        FourthTask(m);
                        break;
                    case "5":
                        FifthTask(m);
                        break;
                    case "6":
                        SixthTask(m);
                        break;
                    case "7":
                        SeventhTask(m);
                        break;
                    case "8":
                        EighthTask(m);
                        break;
                    case "9":
                        NinthTask(m);
                        break;
                    case "10":
                        TenthTask(m);
                        break;
                    default:
                        Console.WriteLine("Invalid input, try again.");
                        break;
                }
            }
        }
        static void DrawLine()
        {
            Console.WriteLine(new string('-', 80));
        }
        static void PrintInfo()
        {
            Console.WriteLine(new string('*', 80));
            Console.WriteLine("Choose from the tasks below and input the corresponding number:\r\n");
            Console.WriteLine("1. Enter a number, of which the last digit will be returned as text.");
            Console.WriteLine("2. Enter a number, and see how many times it appears in the given array.");
            Console.WriteLine("3. Enter an index of the given array, to check if it's greater than it's neighbours.");
            Console.WriteLine("4. Returns the index of the first element, which is larger than both it's neighbours.");
            Console.WriteLine("5. Prints the Input integer in reverse order.");
            Console.WriteLine("6. Enter Two positive int numbers less than 10 000 digits, to be summed.");
            Console.WriteLine("7. Input an array of int numbers, to be sorted by descending.");
            Console.WriteLine("8. Enter an Integer number, from 1 to 100,  to see it's factorial.");
            Console.WriteLine("9. Enter integer numbers, to get they'r average.");
            Console.WriteLine("10. Enter two int nums A and B, to solve for: A * X + B = 0.");
            Console.WriteLine();
            Console.WriteLine("To exit type \"exit\".");
            Console.WriteLine("To see this screen again, type \"info\".");
            Console.WriteLine("To clear the  screen, type \"clear\".");
            Console.WriteLine(new string('*', 80));
        }
        static void FirstTask(TaskMethods methods)
        {
            DrawLine();
            Console.WriteLine("Input a number");
            var num = int.Parse(Console.ReadLine());
            var result = methods.GetLastDigit(num);
            Console.WriteLine(result);
            DrawLine();
        }
        static void SecondTask(TaskMethods methods)
        {
            DrawLine();
            var nums = methods.GenIntArray();
            Console.WriteLine(string.Join(" ", nums));
            var n = int.Parse(Console.ReadLine());
            var result = methods.CountOfNum(nums, n);
            Console.WriteLine(result);
            DrawLine();
        }
        static void ThirdTask(TaskMethods methods)
        {
            DrawLine();
            var nums = methods.GenIntArray();
            Console.Write("  ");
            Console.WriteLine(string.Join("   ", nums));
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($" [{i}]");
            }
            Console.WriteLine();
            Console.WriteLine("Enter an [Index] of an element.");
            var index = int.Parse(Console.ReadLine());
            var result = methods.LargerThanNeighboursCheck(nums, index);
            if(result)
            {
                Console.WriteLine("Chosen element is largest.");
            }
            else
            {
                Console.WriteLine("Chosen element is not largest.");
            }
            DrawLine();
        }
        static void FourthTask(TaskMethods methods)
        {
            DrawLine();
            var nums = methods.GenIntArray();
            Console.Write("  ");
            Console.WriteLine(string.Join("   ", nums));
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($" [{i}]");
            }
            Console.WriteLine();
            Console.WriteLine(" [{0}]", methods.ReturnFirstLargerThanNeighbours(nums));
            DrawLine();
        }
        static void FifthTask(TaskMethods methods)
        {
            DrawLine();
            var n = Console.ReadLine();
            Console.WriteLine(methods.ReverseNum(n));
            DrawLine();
        }
        static void SixthTask(TaskMethods methods)
        {
            DrawLine();
            Console.WriteLine("Input first Number.");
            var first = Console.ReadLine();
            Console.WriteLine("Input Second Number.");
            var second = Console.ReadLine();
            var result = methods.SumHugeNum(first, second);
            Console.WriteLine("Resulting Sum is: {0}", result);
            DrawLine();
        }
        static void SeventhTask(TaskMethods methods)
        {
            DrawLine();
            Console.WriteLine("Input an array of int numbers, separated by a single space.");
            var input = Console.ReadLine();
            var nums = input.Split(' ').Select(i => int.Parse(i)).ToArray();
            var len = nums.Length;
            var tempNum = 0;

            for (int i = 0; i < len; i++)
            {
                tempNum = nums[i];
                var largestNumIndex = methods.GetLargestNumIndex(nums, i, len);
                nums[i] = nums[largestNumIndex];
                nums[largestNumIndex] = tempNum;

            }
            Console.WriteLine("Reversed Array:");
            Console.WriteLine(string.Join(" ", nums));
            DrawLine();
        }
        static void EighthTask(TaskMethods methods)
        {
            DrawLine();
            Console.WriteLine("enter an integer number, from 1 to 100,  to see it's factorial.");
            var n = int.Parse(Console.ReadLine());
            var answer = methods.GetFactorial(n);
            Console.WriteLine("{0}! = {1}", n, answer);
            DrawLine();
        }
        static void NinthTask(TaskMethods methods)
        {
            DrawLine();
            Console.WriteLine("Input integernumbers, separated by a single space:");
            var input = Console.ReadLine();
            var nums = input.Split(' ').Select(i => int.Parse(i)).ToArray();
            var answer = methods.GetAverage(nums);
            Console.WriteLine($"{Math.Round(answer, 6):F6}, rounded to the 6th digit.");
            DrawLine();
        }
        static void TenthTask(TaskMethods methods)
        {
            DrawLine();
            Console.WriteLine("Enter the numbers A!= 0 and B, separated by a single space:");
            var input = Console.ReadLine();
            var nums = input.Split(' ').Select(i => int.Parse(i)).ToArray();
            var result = methods.SolveForX(nums[0], nums[1]);
            Console.WriteLine("X = {0}", result);
        }
    }
}
