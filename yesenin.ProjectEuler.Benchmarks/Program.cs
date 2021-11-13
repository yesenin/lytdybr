using BenchmarkDotNet.Running;

namespace yesenin.ProjectEuler.Benchmark
{
    public static class Program
    {
        public static void Main()
        {
            var summary = BenchmarkRunner.Run<Problem1Benchmark>();
        }
    }
}