using System;

namespace NxN_Matrices
{
    class Program
    {
        static int[,] FillArrayDiagonaly(int n)
        {
            int num = 1;
            int[,] mtrx = new int[n, n];

            for (int i = n - 1; i >= 0; i--)
            {
                int col = 0;
                for (int row = i; row < n; row++)
                {
                    mtrx[row, col] = num;
                    col++;
                    num++;
                }
            }
            for (int i = 1; i <= n - 1; i++)
            {
                int col = 0;
                for (int row = i; row < n; row++)
                {
                    mtrx[col, row] = num;
                    col++;
                    num++;
                }
            }
            return mtrx;
        }
        //For CounterDiagonalyChecking in Compare strings.
        static int[,] FillArrayCounterDiagonaly(int n)
        {
            int num = 1;
            int[,] mtrx = new int[n, n];

            for (int i = n - 1; i >= 0; i--)
            {
                int col = n - 1;
                for (int row = i; row < n - 1; row++)
                {
                    mtrx[row, col] = num;
                    col--;
                    num++;
                }
            }
            for (int i = n - 2; i >= 0; i--)
            {
                int col = 0;
                for (int row = i; row > 0; row--)
                {
                    mtrx[col, row] = num;
                    col++;
                    num++;
                }
            }
            return mtrx;
        }
        static int[,] FillArray(int n)
        {
            int num = 1;
            int[,] mtrx = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                if (row % 2 == 0 || row == 0)
                {
                    for (int col = 0; col < n; col++)
                    {
                        mtrx[col, row] = num;
                        num++;

                    }
                }
                else
                {

                    for (int col = n - 1; col >= 0; col--)
                    {
                        mtrx[col, row] = num;
                        num++;

                    }
                }
            }
            return mtrx;
        }
        static void PrintColumbWise(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                int num = row;
                Console.Write($"  {num}");
                for (int col = 1; col < n; col++)
                {
                    num += n;
                    Console.Write($"  {num}");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //PrintColumbWise(n);
            //int[,] mtrx = FillArrayDiagonaly(n);
            int[,] mtrx = FillArrayCounterDiagonaly(n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mtrx[i, j] > 9)
                    {
                        Console.Write($" {mtrx[i, j]}");
                    }
                    else
                    {
                        Console.Write($"  {mtrx[i, j]}");
                    }

                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
