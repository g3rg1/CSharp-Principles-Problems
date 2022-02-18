using System;

namespace Compare_String_Elements
{
    class Program
    {
        static (int count, string element) CheckDiagon(int n, string[,] mtrx)
        {
            (int longestCount, string longestElement) result;
            int currentCount = 1;
            string currentElement = "";
            result.longestCount = 1;
            result.longestElement = "";

            for (int i = n - 2; i >= 0; i--)
            {
                int col = 0;
                for (int row = i; row < n - 1; row++)
                {
                    if (mtrx[row, col] == mtrx[row + 1, col + 1])
                    {
                        currentCount++;
                        currentElement = mtrx[row, col];
                    }
                    else
                    {
                        currentCount = 1;
                    }
                    if (currentCount > result.longestCount)
                    {
                        result.longestCount = currentCount;
                        result.longestElement = currentElement;
                    }
                    col++;

                }
                currentCount = 1;
            }
            for (int i = 1; i <= n - 2; i++)
            {
                int col = 0;
                for (int row = i; row < n - 1; row++)
                {
                    if (mtrx[row, col] == mtrx[row + 1, col + 1])
                    {
                        currentCount++;
                        currentElement = mtrx[row, col];
                    }
                    else
                    {
                        currentCount = 1;
                    }
                    if (currentCount > result.longestCount)
                    {
                        result.longestCount = currentCount;
                        result.longestElement = currentElement;
                    }
                    col++;
                }
                currentCount = 1;
            }
            return result;
        }
        static (int count, string element) CheckCounterDiagon(int n, string[,] mtrx)
        {
            (int longestCount, string longestElement) result;
            int currentCount = 1;
            string currentElement = "";
            result.longestCount = 1;
            result.longestElement = "";

            for (int i = n - 1; i >= 0; i--)
            {
                int col = n - 1;
                for (int row = i; row < n - 1; row++)
                {
                    if (mtrx[row, col] == mtrx[row + 1, col - 1])
                    {
                        currentCount++;
                        currentElement = mtrx[row, col];
                    }
                    else
                    {
                        currentCount = 1;
                    }
                    if (currentCount > result.longestCount)
                    {
                        result.longestCount = currentCount;
                        result.longestElement = currentElement;
                    }
                    col--;

                }
                currentCount = 1;
            }
            for (int i = n - 2; i >= 0; i--)
            {
                int col = 0;
                for (int row = i; row > 0; row--)
                {
                    if (mtrx[col, row] == mtrx[col + 1, row - 1])
                    {
                        currentCount++;
                        currentElement = mtrx[row, col];
                    }
                    else
                    {
                        currentCount = 1;
                    }
                    if (currentCount > result.longestCount)
                    {
                        result.longestCount = currentCount;
                        result.longestElement = currentElement;
                    }
                    col++;
                }
                currentCount = 1;
            }

            return result;
        }
        static (int count, string element) CheckCols(int n, string[,] mtrx)
        {
            (int longestCount, string longestElement) result;
            int currentCount = 1;
            string currentElement = "";
            result.longestCount = 1;
            result.longestElement = "";
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n - 1; row++)
                {
                    if (mtrx[row, col] == mtrx[row + 1, col])
                    {
                        currentCount++;
                        currentElement = mtrx[row, col];
                    }
                    else
                    {
                        currentCount = 1;
                    }
                    if (currentCount > result.longestCount)
                    {
                        result.longestCount = currentCount;
                        result.longestElement = currentElement;
                    }
                }
                currentCount = 1;
            }
            return result;
        }
        static (int count, string element) CheckRows(int n, string[,] mtrx)
        {
            (int longestCount, string longestElement) resultRow;
            int currentCount = 1;
            string currentElement = "";
            resultRow.longestCount = 1;
            resultRow.longestElement = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (mtrx[i, j] == mtrx[i, j + 1])
                    {
                        currentCount++;
                        currentElement = mtrx[i, j];
                    }
                    else
                    {
                        currentCount = 1;
                    }
                    if (currentCount > resultRow.longestCount)
                    {
                        resultRow.longestCount = currentCount;
                        resultRow.longestElement = currentElement;
                    }
                }
                currentCount = 1;
            }
            return resultRow;
        }
        static void PrintMatrix(int n, string[,] mtrx)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mtrx[i, j].PadRight(5));
                }
                Console.WriteLine("\n");
            }
        }
        static string[,] GenerateMatrix(int n)
        {
            Random rng = new Random();
            string[,] mtrx = new string[n, n];
            int currentElement;
            string elementString = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    currentElement = rng.Next(0, 9);
                    switch (currentElement)
                    {
                        case 0:
                            {
                                elementString = "ha";
                            }
                            break;
                        case 1:
                            {
                                elementString = "fo";
                            }
                            break;
                        case 3:
                            {
                                elementString = "xxx";
                            }
                            break;
                        case 4:
                            {
                                elementString = "fifi";
                            }
                            break;
                        case 5:
                            {
                                elementString = "hi";
                            }
                            break;
                        case 6:
                            {
                                elementString = "xx";
                            }
                            break;
                        case 7:
                            {
                                elementString = "s";
                            }
                            break;
                        case 8:
                            {
                                elementString = "pp";
                            }
                            break;
                        case 9:
                            {
                                elementString = "qq";
                            }
                            break;
                    }
                    mtrx[i, j] = elementString;
                }
            }
            return mtrx;
        }
        static (int count, string element) GetLargestCount(int n, string[,] mtrx)
        {
            (int longestCount, string longestElement) resultCurrent;
            (int longestCount, string longestElement) resultLargest;
            resultLargest.longestCount = 1;
            resultLargest.longestElement = "";

            resultCurrent = CheckRows(n, mtrx);
            if (resultCurrent.longestCount > resultLargest.longestCount)
            {
                resultLargest.longestCount = resultCurrent.longestCount;
                resultLargest.longestElement = resultCurrent.longestElement;
            }
            resultCurrent = CheckCols(n, mtrx);
            if (resultCurrent.longestCount > resultLargest.longestCount)
            {
                resultLargest.longestCount = resultCurrent.longestCount;
                resultLargest.longestElement = resultCurrent.longestElement;
            }
            resultCurrent = CheckDiagon(n, mtrx);
            if (resultCurrent.longestCount > resultLargest.longestCount)
            {
                resultLargest.longestCount = resultCurrent.longestCount;
                resultLargest.longestElement = resultCurrent.longestElement;
            }
            resultCurrent = CheckCounterDiagon(n, mtrx);
            if (resultCurrent.longestCount > resultLargest.longestCount)
            {
                resultLargest.longestCount = resultCurrent.longestCount;
                resultLargest.longestElement = resultCurrent.longestElement;
            }
            return resultLargest;
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string[,] mtrx = GenerateMatrix(n);
            PrintMatrix(n, mtrx);
            (int largestCount, string largestElement) result = GetLargestCount(n, mtrx);
            Console.WriteLine();
            for (int i = 1; i <= result.largestCount; i++)
            {
                Console.Write($" {result.largestElement}");
            }
        }
    }
}
