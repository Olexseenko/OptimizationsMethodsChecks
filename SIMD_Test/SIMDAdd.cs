using System.Numerics;

namespace SIMD_Test
{
    public class SIMDAdd
    {
        public static void AddWithSIMD_Int(int[] matrx, int leangth)
        {
            var zeroVector = new Vector<int>(10);
            for (int i = 0; i < leangth; i += Vector<int>.Count)
            {
                var MatrxVector = new Vector<int>(matrx, i);
                var ResultVector = MatrxVector + zeroVector;
                ResultVector.CopyTo(matrx, i);
            }
        }

        public static void AddWithOutSIMD_Int(int[] matrx, int leangth)
        {
            for (int i = 0; i < leangth; i++)
            {
                matrx[i] += 10;
            }
        }

        public static void AddWithSIMD_Float(float[] matrx, int leangth)
        {
            var zeroVector = new Vector<float>(10);
            for (int i = 0; i < leangth; i += Vector<float>.Count)
            {
                var MatrxVector = new Vector<float>(matrx, i);
                var ResultVector = MatrxVector + zeroVector;
                ResultVector.CopyTo(matrx, i);
            }
        }

        public static void AddWithOutSIMD_Float(float[] matrx, int leangth)
        {
            for (int i = 0; i < leangth; i++)
            {
                matrx[i] += 10;
            }
        }

        public static void AddWithSIMD_Double(double[] matrx, int leangth)
        {
            var zeroVector = new Vector<double>(10);
            for (int i = 0; i < leangth; i += Vector<double>.Count)
            {
                var MatrxVector = new Vector<double>(matrx, i);
                var ResultVector = MatrxVector + zeroVector;
                ResultVector.CopyTo(matrx, i);
            }
        }

        public static void AddWithOutSIMD_Double(double[] matrx, int leangth)
        {
            for (int i = 0; i < leangth; i++)
            {
                matrx[i] += 10;
            }
        }
    }
}
