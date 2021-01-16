using System;
using System.Linq;
using System.Numerics;

namespace abc156d
{
    class Program
    {

        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();
            var (n, a, b) = (inputs[0], inputs[1], inputs[2]);

            /*
            Console.WriteLine(Combination(7, 1));
            Console.WriteLine(Combination(7, 2));
            Console.WriteLine(Combination(7, 3));
            */

            var res = Pow(2, n) + mod+mod -1;
            var res1 = Combination(n, a);
            var res2 = Combination(n, b);

            Console.WriteLine((res - res1 - res2)%mod);
        }

        static BigInteger mod = 1000000007;
        //a^p-2 ≡ a^-1 (mod M)
        static BigInteger Inverse(BigInteger a)
        {
            return Pow(a, mod - 2);
        }

        //繰り返し2乗法
        static BigInteger Pow(BigInteger a, BigInteger b)
        {
            if (b == 0) return 1;
            if (b % 2 == 0)
            {
                BigInteger d = Pow(a, b / 2);
                return d * d % mod;
            }
            else
            {
                return a * Pow(a, b - 1) % mod;
            }
        }

        static BigInteger Factorial(BigInteger n)
        {
            if (n == 0) return 1;
            return Factorial(n - 1) * n % mod;
        }

        static BigInteger Combination(BigInteger n, BigInteger k)
        {
            BigInteger X = 1;
            BigInteger Y = 1;

            for (BigInteger i = 0; i < k; i++) X = X * (n-i) % mod;
            for (BigInteger i = 1; i <= k; i++) Y = Y * i % mod;

            return X*Inverse(Y)%mod;
            // return ( (X % mod) * Inverse(Y) ) % mod;
            // return (Factorial(n) * Inverse(Factorial(n - k)) % mod) * Inverse(Factorial(k)) % mod;
        }
    }
}
