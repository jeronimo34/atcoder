using System;
using System.Linq;
using System.Numerics;

namespace abc034c
{
    class Program
    {
       

        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int W = inputs[0];
            int H = inputs[1];

            Console.WriteLine(Combination(W+H-2, W-1));
        }

        static long mod = 1000000007;
        //a^p-2 ≡ a^-1 (mod M)
        static long Inverse(long a) {
            return Pow(a, mod-2);
        }

        //繰り返し2乗法
        static long Pow(long a, long b) 
        {
            if (b == 0) return 1;
            if (b % 2 == 0)
            {
                long d = Pow(a, b / 2);
                return d * d % mod;
            }
            else 
            {
                return a*Pow(a, b - 1) % mod;
            }            
        }

        static long Factorial(long n) 
        {
            if (n == 0) return 1;
            return Factorial(n - 1) * n % mod;            
        }

        static long Combination(int n, int k) { 
            return (Factorial(n) * Inverse(Factorial(n - k)) % mod) * Inverse(Factorial(k)) % mod;
        }


    }
}
