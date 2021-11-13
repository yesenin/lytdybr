using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace yesenin.ProjectEuler
{
    /// <summary>
    /// Even Fibonacci numbers
    /// </summary>
    public class Problem2
    {
        public static int SolveWithCount(int n)
        {
            var evenFibs = new List<int>();
            var generator = new FibonacciGenerator();
            foreach (var fib in generator.GetFirst(n))
            {
                if (fib % 2 == 0)
                {
                    evenFibs.Add(fib);
                }
            }

            return evenFibs.Sum();
        }
        
        public static int SolveBelow(int limit)
        {
            var evenFibs = new List<int>();
            var generator = new FibonacciGenerator();
            foreach (var fib in generator.GetBelow(limit))
            {
                if (fib % 2 == 0)
                {
                    evenFibs.Add(fib);
                }
            }

            return evenFibs.Sum();
        }
        
        public static int SolveBelow2(int limit)
        {
            var generator = new FibonacciGenerator();
            return generator.GetEvenBelow(limit).Sum();
        }
        
        public class FibonacciGenerator
        {
            private int a = 1;
            private int b = 0;

            public IEnumerable<int> GetFirst(int n)
            {
                Reset();
                for (var i = 0; i < n; i++)
                {
                    yield return a + b;
                    MakeNewFib();
                }
            }
            
            public IEnumerable<int> GetBelow(int limit)
            {
                Reset();
                while (a + b < limit)
                {
                    yield return a + b;
                    MakeNewFib();
                }
            }

            public IEnumerable<int> GetEvenBelow(int limit)
            {
                Reset();
                while (a + b < limit)
                {
                    if ((a + b) % 2 == 0)
                    {
                        yield return a + b;
                    }

                    MakeNewFib();
                }
            }

            private void MakeNewFib()
            {
                var t = b;
                b = a;
                a += t;
            }

            private void Reset()
            {
                a = 1;
                b = 0;
            }
        }
    }
}