using System.Linq;
using FluentAssertions;
using Xunit;

namespace yesenin.ProjectEuler.Tests
{
    public class Problem2Tests
    {
        [Fact]
        public void FibonacciGeneratorTest()
        {
            var generator = new Problem2.FibonacciGenerator();

            var a = generator.GetFirst(2).ToArray();

            a.Length.Should().Be(2);
            a.Should().BeEquivalentTo(new[] {1, 2});
            
            var b = generator.GetFirst(3).ToArray();

            b.Length.Should().Be(3);
            b.Should().BeEquivalentTo(new[] {1, 2, 3});

            var c = generator.GetBelow(4).ToArray();
            c.Length.Should().Be(3);
            c.Should().BeEquivalentTo(b);
        }

        [Fact]
        public void SolveTest()
        {
            var a = Problem2.SolveWithCount(10);

            a.Should().Be(44);
            
            var b = Problem2.SolveBelow(90);

            b.Should().Be(44);

            var c = Problem2.SolveBelow(4000000);
            c.Should().Be(4613732);
        }
    }
}