using System;
using System.Numerics;

namespace ABC070C
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());

            BigInteger res = 1;
            for (BigInteger i = 0; i < N; ++i)
            {
                BigInteger T = BigInteger.Parse(Console.ReadLine());
                res = lcm(res, T);
            }

            Console.WriteLine(res);
        }

        static BigInteger lcm(BigInteger a, BigInteger b) => a * b / gcd(a, b);
        static BigInteger gcd(BigInteger a, BigInteger b) => (b == 0) ? a : gcd(b, a % b);
    }
}
