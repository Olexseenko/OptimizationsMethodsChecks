using System.Numerics;

namespace SIMD_Test
{
    public class SIMDZero
    {
        public static void ZeroWithSIMD_Int(int[] matrx, int leangth)
        {
            var zeroVector = Vector<int>.Zero;
            for (int i = 0; i < leangth; i += Vector<int>.Count)
            {
                zeroVector.CopyTo(matrx, i);
            }
        }

        public static void ZeroWithOutSIMD_Int(int[] matrx, int leangth)
        {
            for (int i = 0; i < leangth; i++)
            {
                matrx[i] = 0;
            }
        }

        public static void ZeroWithSIMD_Float(float[] matrx, int leangth)
        {
            var zeroVector = Vector<float>.Zero;
            for (int i = 0; i < leangth; i += Vector<float>.Count)
            {
                zeroVector.CopyTo(matrx, i);
            }
        }

        public static void ZeroWithOutSIMD_Float(float[] matrx, int leangth)
        {
            for (int i = 0; i < leangth; i++)
            {
                matrx[i] += 10;
            }
        }

        public static void ZeroWithSIMD_Double(double[] matrx, int leangth)
        {
            var zeroVector = Vector<double>.Zero;
            for (int i = 0; i < leangth; i += Vector<double>.Count)
            {
                zeroVector.CopyTo(matrx, i);
            }
        }

        public static void ZeroWithOutSIMD_Double(double[] matrx, int leangth)
        {
            for (int i = 0; i < leangth; i++)
            {
                matrx[i] = 0;
            }
        }
    }
}
