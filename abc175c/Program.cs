using System;
using System.Linq;
using System.Numerics;

namespace abc175c
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] inputs = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();

            BigInteger x = inputs[0];
            BigInteger k = inputs[1];
            BigInteger d = inputs[2];

            BigInteger n = BigInteger.Min(k, BigInteger.Abs(x) / d);
            
            if ((k - n) % 2 == 0)
            {
                Console.WriteLine(BigInteger.Abs(BigInteger.Abs(x) - d* n));
            }
            else {
                Console.WriteLine(BigInteger.Abs(BigInteger.Abs(x) - d * (n+1)));
            }
        }
    }
}
