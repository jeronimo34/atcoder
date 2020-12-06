using System;
using System.Linq;

namespace arc110a
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = long.Parse( Console.ReadLine());

            long res = 2;
            for (int i = 3; i <= N; ++i) {
                res = lcm(res, i);
            }

            Console.WriteLine(res + 1);
        }

        static long lcm(long a, long b) => a * b / gcd(a, b);
        static long gcd(long a, long b) => (b == 0) ? a : gcd(b, a % b);
    }
}
