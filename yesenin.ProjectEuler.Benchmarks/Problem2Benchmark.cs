using BenchmarkDotNet.Attributes;

namespace yesenin.ProjectEuler.Benchmarks
{
    public class Problem2Benchmark : BaseBenchmark
    {
        private readonly int limit = 4000000;

        [Benchmark]
        public int Method1()
        {
            return Problem2.SolveBelow(limit);
        }

        [Benchmark]
        public int Method2()
        {
            return Problem2.SolveBelow2(limit);
        }
    }
}