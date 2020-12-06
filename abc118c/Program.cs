using System;
using System.Linq;

namespace abc118c
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            var A = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

            var res = A[0];
            for (var i = 1; i < N; ++i) {
                res = gcd(res, A[i]);
            }
            Console.WriteLine(res);
        }

        static long gcd(long a, long b) => (b == 0) ? a : gcd(b, a % b);
    }
}
