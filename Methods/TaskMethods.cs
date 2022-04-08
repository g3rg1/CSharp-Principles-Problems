using System;
using System.Numerics;
using System.Text;

namespace Methods
{
    public class TaskMethods
    {
        public string GetLastDigit(double num)
        {
            var lastnum = Convert.ToString(num);
            if(lastnum.Contains("."))
            {
                lastnum = lastnum.Remove(lastnum.IndexOf('.'), 1);
            }
            var inWords = new string[]{ "zero", "one", "two",
                                        "three", "four", "five",
                                        "six", "seven", "eight", "nine",};
            var index = lastnum[lastnum.Length - 1] - '0';
            return inWords[index];
        }
        public int[] GenIntArray()
        {
            var rng = new Random();
            var nums = new int[rng.Next(5, 10)];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rng.Next(0, 10);
            }
            return nums;
        }
        public int CountOfNum(int[] nums ,int n)
        {
            var count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == n)
                {
                    count++;
                }
            }
            return count;
        }
        public bool LargerThanNeighboursCheck(int[] nums, int index)
        {
            bool rightNeibour;
            bool leftNeibour;
            bool result;
            int lastIndex = nums.Length - 1;

            if(index + 1 > lastIndex)
            {
                rightNeibour = true;
            }
            else
            {
                if(nums[index] > nums[index + 1])
                {
                    rightNeibour = true;
                }
                else
                {
                    rightNeibour = false;
                }
            }

            if (index - 1 < 0)
            {
                leftNeibour = true;
            }
            else
            {
                if (nums[index] > nums[index - 1])
                {
                    leftNeibour = true;
                }
                else
                {
                    leftNeibour = false;
                }
            }

            if(!leftNeibour || !rightNeibour)
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }
        public int ReturnFirstLargerThanNeighbours(int[] nums)
        {
            int result = -1;
            for (int i = 1; i < nums.Length-1; i++)
            {
                if(nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
                {
                    result = i;
                    break;
                }
            }

            return result;
        }
        public string ReverseNum(string num)
        {
            var elements = new char[num.Length];
            int eleIdnex = 0;
            for (int i = num.Length-1; i >= 0; i--)
            {
                elements[eleIdnex] = num[i];
                eleIdnex++;
            }
            return string.Join("", elements);
        }
        public string SumHugeNum(string firstNum, string secondNum)
        {
            var first = ReverseNum(firstNum);
            var second = ReverseNum(secondNum);
            var leftOver = 0;
            var len = Math.Min(first.Length, second.Length);
            var maxLen = Math.Max(first.Length, second.Length);
            var sb = new StringBuilder();
            var otherNum = "";

            for (int i = 0; i < len; i++)
            {
                int currentNum = (first[i] - '0') + (second[i] - '0');
                currentNum += leftOver;
                leftOver = 0;

                if(currentNum >= 10)
                {
                    leftOver++;
                    currentNum -= 10;
                }

                sb.Append(currentNum);
            }

            if(leftOver != 0 && first.Length == second.Length)
            {
                sb.Append(leftOver);
            }

            if (first.Length != second.Length)
            {
                if (first.Length > second.Length)
                {
                    otherNum = first;
                }
                else
                {
                    otherNum = second;
                }

                for (int i = len; i < maxLen; i++)
                {
                    int currentNum = (otherNum[i] - '0');
                    currentNum += leftOver;
                    leftOver = 0;

                    if (currentNum >= 10)
                    {
                        leftOver++;
                        currentNum -= 10;
                    }

                    sb.Append(currentNum);
                }
            }

            if (leftOver != 0 && first.Length != second.Length)
            {
                sb.Append(leftOver);
            }

            var resultReverse =  sb.ToString();
            var result = new StringBuilder();
            for (int i = resultReverse.Length - 1; i >= 0; i--)
            {
                result.Append(resultReverse[i]); 
            }
            return result.ToString();
        }
        public int GetLargestNumIndex(int[] arr, int startIndex, int stopIndex)
        {
            var maxNum = int.MinValue;
            var index = 0;

            for (int i = startIndex; i < stopIndex; i++)
            {
                if (arr[i] > maxNum)
                {
                    maxNum = arr[i];
                    index = i;
                }
            }

            return index;
        }
        public string GetFactorial(int number)
        {
            BigInteger result = new BigInteger();
            result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result.ToString();
        }
        public double GetAverage(int[] arr)
        {
            var sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return (double)(sum / arr.Length);
        }
        public double SolveForX(int a, int b)
        {
            double result = a / b;
            return -result;
        }
    }
}
