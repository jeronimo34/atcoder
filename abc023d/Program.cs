using System;
using System.Linq;
using System.Numerics;

namespace abc023d
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = BigInteger.Parse(Console.ReadLine());

            BigInteger res = 1000000000000000000;
            for (var i = 0; i < N; ++i) 
            {
                var inputs = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();
                var H = inputs[0];
                var S = inputs[1];
                res = BigInteger.Min(res, S * (N - 1) + H);
            }
            Console.WriteLine(res);
        }
    }
}
