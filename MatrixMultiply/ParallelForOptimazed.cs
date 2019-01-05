using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixMultiply
{
    public class ParallelForOptimazed
    {
        public static void MatrxMultiply2D(double[,] matrx1, double[,] matrx2, double[,] matrxRes,
            int matrx1Rows, int matrx1Cols, int matrx2Cols)
        {
            //int matrx2Rows = matrx1Cols;
            for (int i = 0; i < matrx1Rows; i++)
            {
                for (int j = 0; j < matrx2Cols; j++)
                {
                    matrxRes[i, j] = 0;
                    for (int k = 0; k < matrx1Cols; k++)
                    {
                        matrxRes[i, j] += matrx1[i, k] * matrx2[k, j];
                    }
                }
            }
        }
    }
}
