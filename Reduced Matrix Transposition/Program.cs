using System;

namespace Reduced_Matrix_Transposition
{
    public class Program
    {
        public static double[,] GenMatrix()
        {
            Random rng = new Random();
            int n = rng.Next(0, 11);
            int m = rng.Next(0, 11);
            bool zeroMatrix = n == 0 || m == 0;
            if (zeroMatrix)
            {
                m = 0;
                n = 0;
            }
            double[,] matrix = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rng.Next(0, 10);
                }
            }
            return matrix;
        }
        public static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($" {matrix[i, j]}".PadLeft(4));
                }
                Console.WriteLine();
            }
        }
        public static double[,] TransponateMatrix(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            double[,] transMatrix = new double[m, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    transMatrix[j, i] = matrix[i, j];
                }
            }
            return transMatrix;
        }
        public static double[,] DividedByRowMatrix(double[,] matrix, double[,] transMatrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            double[] dividers = new double[n];
            double[,] dividedMatrix = new double[transMatrix.GetLength(0), transMatrix.GetLength(1)];
            double rowSum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    rowSum += matrix[i, j];
                }
                dividers[i] = rowSum;
                rowSum = 0;
            }

            for (int i = 0; i < transMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < transMatrix.GetLength(1); j++)
                {
                    var element = transMatrix[i, j];

                    element = element / dividers[j];

                    dividedMatrix[i, j] = Math.Round(element, 3);
                }
            }
            return dividedMatrix;
        }
        private static void Main(string[] args)
        {
            double[,] matrix = GenMatrix();
            Console.WriteLine("Matrix:");
            PrintMatrix(matrix);
            Console.WriteLine();
            double[,] transponatedMatrix = TransponateMatrix(matrix);
            Console.WriteLine("Transponated Matrix:");
            PrintMatrix(transponatedMatrix);
            Console.WriteLine();
            double[,] dividedByRowMatrix = DividedByRowMatrix(matrix, transponatedMatrix);
            Console.WriteLine("Divided by its elements Matrix:");
            PrintMatrix(dividedByRowMatrix);
        }
    }
}