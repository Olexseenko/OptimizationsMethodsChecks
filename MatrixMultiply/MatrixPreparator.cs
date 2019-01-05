using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixMultiply
{
    public class MatrixPreparator
    {
        public static int[] RandomVectorInt(int leanth)
        {
            var matrx = new int[leanth];
            var Rand = new Random();
            for (int i = 0; i < leanth; i++)
            {
                matrx[i] = Rand.Next(1000);
            }
            return matrx;
        }

        public static float[] RandomVectorFloat(int leanth)
        {
            var matrx = new float[leanth];
            var Rand = new Random();
            for (int i = 0; i < leanth; i++)
            {
                matrx[i] = (float)(Rand.NextDouble() * 1000);
            }
            return matrx;
        }

        public static double[] RandomVectorDouble(int leanth)
        {
            var matrx = new double[leanth];
            var Rand = new Random();
            for (int i = 0; i < leanth; i++)
            {
                matrx[i] = Rand.NextDouble() * 1000;
            }
            return matrx;
        }

        public static double[] RandomMatrixDoble1D(int rows, int cols)
        {
            var matrx = new double[rows*cols];
            var Rand = new Random();
            for (int i = 0; i < rows*cols; i++)
            {
                    matrx[i] =Rand.NextDouble() * 1000;
            }
            return matrx;
        }

        public static double[,] RandomMatrixDoble2D(int rows, int cols)
        {
            var matrx = new double[rows,cols];
            var Rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrx[i,j] = Rand.NextDouble() * 1000;
                }
            }
            return matrx;
        }
    }
}
