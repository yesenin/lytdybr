using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace yesenin.ProjectEuler.Benchmarks
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(RuntimeMoniker.Net50)]
    public abstract class BaseBenchmark
    {
        
    }
}