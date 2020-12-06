using System;
using System.Linq;
using System.Numerics;

namespace arc108a
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();
            var s = inputs[0];
            var p = inputs[1];

            for (BigInteger i = 0; i <= 1000000; ++i)
            {
                if (i * i - s * i + p == 0) {
                    Console.WriteLine("Yes");
                    return;
                }

            }

            Console.WriteLine("No");
        }
    }
}
