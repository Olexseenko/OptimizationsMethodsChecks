using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;
using MatrixMultiply;

namespace OptimizationTesting
{
    public class MatrixMultiplyTest
    {
        public double[,] matrixResult;
        private readonly double[,] matrix1, matrix2;
        private readonly int matrxLeanth = 1000;
        public MatrixMultiplyTest()
        {
            matrix1 = MatrixPreparator.RandomMatrixDoble2D(matrxLeanth,matrxLeanth);
            matrix2 = MatrixPreparator.RandomMatrixDoble2D(matrxLeanth, matrxLeanth);
            matrixResult = new double[matrxLeanth, matrxLeanth];
        }

        [Benchmark]
        public void SimpleSingleMultiply() => MatrixMultiply.SimpleSingleThread.
            MatrxMultiply2D(matrix1, matrix2, matrixResult, matrxLeanth, matrxLeanth, matrxLeanth);
    }
}
