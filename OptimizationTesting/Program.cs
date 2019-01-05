using BenchmarkDotNet.Running;

namespace OptimizationTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<SIMDTest>();
            //var summary = BenchmarkRunner.Run<MatrixMultiplyTest>();
        }
    }
}
