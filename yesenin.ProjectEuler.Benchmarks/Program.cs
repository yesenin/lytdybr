using BenchmarkDotNet.Running;

namespace yesenin.ProjectEuler.Benchmarks
{
    public static class Program
    {
        public static void Main()
        {
            // var problem1Summary = BenchmarkRunner.Run<Problem1Benchmark>();
            var problem2Summary = BenchmarkRunner.Run<Problem2Benchmark>();
        }
    }
}