using FluentAssertions;

namespace yesenin.ProjectEuler
{
    /// <summary>
    /// Multiples of 3 or 5
    /// </summary>
    public class Problem1 : BaseProblem
    {
        public override string GetAnswer()
        {
            var answer = Solve2(1000);
            return answer.ToString();
        }

        public override void AssertTest()
        {
            var answer = Solve2(10);
            answer.Should().Be(23);
        }

        public static int Solve(int limit)
        {
            int result = 0;

            for (var i = 1; i < limit; i++)
            {
                if (i % 3 == 0)
                {
                    result += i;
                }
                else if (i % 5 == 0)
                {
                    result += i;
                }
            }

            return result;
        }
        
        public static int Solve2(int limit)
        {
            int result = 0;

            for (var i = 0; i < limit; i += 3)
            {
                result += i % 5 == 0 ? 0 : i;
            }
            
            for (var i = 0; i < limit; i += 5)
            {
                result += i;
            }

            return result;
        }
    }
}