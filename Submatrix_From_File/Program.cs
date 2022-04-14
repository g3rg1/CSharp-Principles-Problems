using System;
using System.Collections.Generic;
using System.IO;

namespace Submatrix_From_File
{
    class Program
    {
        static int[,] GetMtrxFromFile(string matrixPath)
        {
            var input = new List<string>();
            using (var rl = new StreamReader(matrixPath))
            {
                var line = "";
                while ((line = rl.ReadLine()) != null)
                {
                    input.Add(line);
                }
            }
            var n = int.Parse(input[0]);
            var mtx = new int[n, n];
            input.RemoveAt(0);

            for (int i = 0; i < mtx.GetLength(0); i++)
            {
                var inputRow = input[i].Split(' ');

                for (int j = 0; j < mtx.GetLength(1); j++)
                {
                    mtx[i, j] = int.Parse(inputRow[j]);
                }
            }

            return mtx;
        }
        static int[] GetResult(int[,] mtx)
        {
            var subMtx = new int[5];
            var maxSum = int.MinValue;

            for (int i = 0; i < mtx.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < mtx.GetLength(1) - 1; j++)
                {
                    var currentSum = 0;
                    currentSum += mtx[i, j] + mtx[i, j + 1] + mtx[i + 1, j] + mtx[i + 1, j + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        subMtx[0] = maxSum;
                        subMtx[1] = mtx[i, j];
                        subMtx[2] = mtx[i, j + 1];
                        subMtx[3] = mtx[i + 1, j];
                        subMtx[4] = mtx[i + 1, j + 1];
                    }
                }
            }
            return subMtx;
        }
        static void Main(string[] args)
        {
            var matrixPath = @"..\..\..\Matrix.txt";
            var mtx = GetMtrxFromFile(matrixPath);
            var result = GetResult(mtx);
            
            Console.WriteLine($"max sum of subMatrix 2x2 = {result[0]}");
            Console.WriteLine($"{result[1]} {result[2]}");
            Console.WriteLine($"{result[3]} {result[4]}");
        }
    }
}
