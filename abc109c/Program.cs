using System;
using System.Collections.Generic;
using System.Linq;

namespace abc109c
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            var N = inputs[0];
            var X = inputs[1];
            var x = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToList();

            x.Add(X);
            x.Sort();

            List<long> distance = new List<long>();

            for (int i = 1; i < N + 1; ++i) {
                distance.Add(x[i] - x[i - 1]);
            }

            long res = distance[0];
            for (int i = 1; i < N; ++i) {
                res = gcd(distance[i], res);
            }

            Console.WriteLine(res);            
        }

        static long lcm(long a, long b) => a * b / gcd(a, b);
        static long gcd(long a, long b) => (b == 0) ? a : gcd(b, a % b);
    }
}
