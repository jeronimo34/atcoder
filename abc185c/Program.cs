using System;
using System.Numerics;

namespace abc185c
{
    class Program
    {
        static BigInteger L;

        static void Main(string[] args)
        {
            L = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(Combination(L-1, 11));
        }

        // static long mod = 1000000007;
        //a^p-2 ≡ a^-1 (mod M)
        /*
        static long Inverse(long a)
        {
            return Pow(a, mod - 2);
        }*/

        //繰り返し2乗法
        /*
        static ulong Pow(BigInteger a, ulong b)
        {
            if (b == 0) return 1;
            if (b % 2 == 0)
            {
                ulong d = Pow(a, b / 2);
                return d * d;// % mod;
            }
            else
            {
                return a * Pow(a, b - 1);// % mod;
            }
        }*/

        static BigInteger Factorial(BigInteger n)
        {
            if (n == 0) return 1;
            return Factorial(n - 1) * n;
        }

        static BigInteger Combination(BigInteger n, BigInteger k)
        {
            return Factorial(n) / (Factorial(n - k) * Factorial(k));
        }

    }
}
