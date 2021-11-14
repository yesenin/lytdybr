using System;
using System.Collections.Generic;
using System.Linq;

namespace yesenin.ProjectEuler
{
    /// <summary>
    /// Largest prime factor
    /// </summary>
    public static class Problem3
    {
        public static int Solve(long n)
        {
            var generator = new PrimeGenerator();
            var primeFactor = new List<int>();
            var prime = generator.NextPrime();
            while (n != 1)
            {
                if (n % prime == 0)
                {
                    primeFactor.Add(prime);
                    n = n / prime;
                }
                else
                {
                    prime = generator.NextPrime();
                }
            }

            return primeFactor.Distinct().Max();
        }
    }

    public class PrimeGenerator
    {
        private int _current = 2;
        private int _next = 3;

        public int NextPrime()
        {
            var result = _current;

            _current = _next;

            _next += 1;
            
            while (!IsPrime(_next))
            {
                _next += 1;
            }
            
            return result;
        }

        public bool IsPrime(int n)
        {
            if (n > 2 && n % 2 == 0)
            {
                return false;
            }
            var div = 1;
            var sqrtN = Math.Sqrt(n);
            var factor = new List<int>();
            
            while (div <= sqrtN)
            {
                if (n % div == 0)
                {
                    if (n / div != div)
                    {
                        factor.Add(div);
                    }

                    factor.Add(n/div);
                }
                div += 1;
            }

            return factor.Count == 2;
        }

        public void Reset()
        {
            _current = 2;
            _next = 3;
        }
    }
}