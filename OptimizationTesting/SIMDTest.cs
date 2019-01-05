using MatrixMultiply;
using BenchmarkDotNet.Attributes;

namespace OptimizationTesting
{
    public class SIMDTest
    {
        public int[] vector_int;
        public float[] vector_float;
        public double[] vector_double;
        private readonly int matrx1DLeanth = 4000;

        public SIMDTest()
        {
            vector_int = MatrixPreparator.RandomVectorInt(matrx1DLeanth);
            vector_float = MatrixPreparator.RandomVectorFloat(matrx1DLeanth);
            vector_double = MatrixPreparator.RandomVectorDouble(matrx1DLeanth);
        }
        //---------------------------------------Zero_Test------------------------------------

        [Benchmark]
        public void ZeroWithSimd_Int() => SIMD_Test.SIMDZero.ZeroWithSIMD_Int(vector_int, matrx1DLeanth);

        [Benchmark]
        public void ZeroWithOutSimd_Int() => SIMD_Test.SIMDZero.ZeroWithOutSIMD_Int(vector_int, matrx1DLeanth);

        [Benchmark]
        public void ZeroWithSimd_Float() => SIMD_Test.SIMDZero.ZeroWithSIMD_Float(vector_float, matrx1DLeanth);

        [Benchmark]
        public void ZeroWithOutSimd_Float() => SIMD_Test.SIMDZero.ZeroWithOutSIMD_Float(vector_float, matrx1DLeanth);

        [Benchmark]
        public void ZeroWithSimd_Double() => SIMD_Test.SIMDZero.ZeroWithSIMD_Double(vector_double, matrx1DLeanth);

        [Benchmark]
        public void ZeroWithOutSimd_Double() => SIMD_Test.SIMDZero.ZeroWithOutSIMD_Double(vector_double, matrx1DLeanth);

        //---------------------------------------Add_Test------------------------------------

        [Benchmark]
        public void AddWithSimd_Int() => SIMD_Test.SIMDAdd.AddWithSIMD_Int(vector_int, matrx1DLeanth);

        [Benchmark]
        public void AddWithOutSimd_Int() => SIMD_Test.SIMDAdd.AddWithOutSIMD_Int(vector_int, matrx1DLeanth);

        [Benchmark]
        public void AddWithSimd_Float() => SIMD_Test.SIMDAdd.AddWithSIMD_Float(vector_float, matrx1DLeanth);

        [Benchmark]
        public void AddWithOutSimd_Float() => SIMD_Test.SIMDAdd.AddWithOutSIMD_Float(vector_float, matrx1DLeanth);

        [Benchmark]
        public void AddWithSimd_Double() => SIMD_Test.SIMDAdd.AddWithSIMD_Double(vector_double, matrx1DLeanth);

        [Benchmark]
        public void AddWithOutSimd_Double() => SIMD_Test.SIMDAdd.AddWithOutSIMD_Double(vector_double, matrx1DLeanth);

        //---------------------------------------Multiply_Test------------------------------------

        [Benchmark]
        public void MultiplyWithSimd_Int() => SIMD_Test.SIMDMultiply.MultiplyWithSIMD_Int(vector_int, matrx1DLeanth);

        [Benchmark]
        public void MultiplyWithOutSimd_Int() => SIMD_Test.SIMDMultiply.MultiplyWithOutSIMD_Int(vector_int, matrx1DLeanth);

        [Benchmark]
        public void MultiplyWithSimd_Float() => SIMD_Test.SIMDMultiply.MultiplyWithSIMD_Float(vector_float, matrx1DLeanth);

        [Benchmark]
        public void MultiplyWithOutSimd_Float() => SIMD_Test.SIMDMultiply.MultiplyWithOutSIMD_Float(vector_float, matrx1DLeanth);

        [Benchmark]
        public void MultiplyWithSimd_Double() => SIMD_Test.SIMDMultiply.MultiplyWithSIMD_Double(vector_double, matrx1DLeanth);

        [Benchmark]
        public void MultiplyWithOutSimd_Double() => SIMD_Test.SIMDMultiply.MultiplyWithOutSIMD_Double(vector_double, matrx1DLeanth);
    }
}
