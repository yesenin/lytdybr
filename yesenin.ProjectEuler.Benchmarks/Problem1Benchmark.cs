using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace yesenin.ProjectEuler.Benchmark
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(RuntimeMoniker.Net50)]
    public class Problem1Benchmark
    {
        private readonly int limit = 1000;

        [Benchmark]
        public int Method1()
        {
            return Problem1.Solve(limit);
        }

        [Benchmark]
        public int Method2()
        {
            return Problem1.Solve2(limit);
        }
        
        [Benchmark]
        public int Method3()
        {
            return FProblem1.solve(limit);
        }
    }
}