using System;
using Reduced_Matrix_Transposition;

namespace Neighboring_Cells

{
    class Program1 : Program
    {
        static double[,] GetBorders(double[,] mtrx, int x, int y)
        {
            double[,] borderedMtrx = new double[x + 2, y + 2];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    borderedMtrx[i + 1, j + 1] = mtrx[i, j];
                }
            }
            return borderedMtrx;
        }
        static double[,] CalculateNewMatrix(double[,] mtrx, int x, int y)
        {
            double[,] resultMtrx = new double[x, y];
            double topBot = 0;
            double leftRight = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    topBot = mtrx[i, j + 1] + mtrx[i + 2, j + 1];
                    leftRight = mtrx[i + 1, j] + mtrx[i + 1, j + 2];
                    resultMtrx[i, j] = topBot - leftRight;
                }
            }
            return resultMtrx;
        }
        static void Main(string[] args)
        {
            double[,] mtrx = GenMatrix();
            //double[,] mtrx = new double[2, 2] { { 1, 2 }, { 1, 2 } };
            int x = mtrx.GetLength(0);
            int y = mtrx.GetLength(1);
            PrintMatrix(mtrx);
            double[,] borderMatrix = GetBorders(mtrx, x, y);
            PrintMatrix(borderMatrix);
            double[,] calcMatrix = CalculateNewMatrix(borderMatrix, x, y);
            PrintMatrix(calcMatrix);
        }
    }
}
