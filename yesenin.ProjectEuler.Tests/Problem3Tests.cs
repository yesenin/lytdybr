using FluentAssertions;
using Xunit;

namespace yesenin.ProjectEuler.Tests
{
    public class Problem3Tests
    {
        [Fact]
        public void PrimeGenerator_Test()
        {
            var generator = new PrimeGenerator();

            generator.IsPrime(2).Should().BeTrue();
            generator.IsPrime(3).Should().BeTrue();
            generator.IsPrime(4).Should().BeFalse();
            generator.IsPrime(5).Should().BeTrue();
            
            generator.IsPrime(23).Should().BeTrue();
            generator.IsPrime(25).Should().BeFalse();
        }

        [Fact]
        public void NextPrime_Test()
        {
            var generator = new PrimeGenerator();

            generator.NextPrime().Should().Be(2);
            generator.NextPrime().Should().Be(3);
            generator.NextPrime().Should().Be(5);
        }

        [Fact]
        public void Solve_Test()
        {
            var a = Problem3.Solve(13195);

            a.Should().Be(29);
            
            var b = Problem3.Solve(600851475143);

            b.Should().Be(6857);
        }
    }
}