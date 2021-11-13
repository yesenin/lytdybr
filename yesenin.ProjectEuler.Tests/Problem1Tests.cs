using FluentAssertions;
using Xunit;

namespace yesenin.ProjectEuler.Tests
{
    public class Problem1Tests
    {
        [Fact]
        public void SolveTest()
        {
            var a = Problem1.Solve(10);
            a.Should().Be(23);
            
            var b = Problem1.Solve(1000);
            b.Should().Be(233168);
        }
        
        [Fact]
        public void Solve2Test()
        {
            var a = Problem1.Solve2(10);
            a.Should().Be(23);
            
            var b = Problem1.Solve2(1000);
            b.Should().Be(233168);
        }
    }
}