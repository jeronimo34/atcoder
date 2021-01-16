using System;
using System.Linq;
using System.Numerics;

namespace arc111a
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();
            var N = inputs[0];
            var M = inputs[1];
            var res = BigInteger.ModPow(10, N, M*M) / M % M;
            Console.WriteLine(res);
        }
    }
}
