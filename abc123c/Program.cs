using System;
using System.Numerics;

namespace abc123c
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = BigInteger.Parse(Console.ReadLine());

            var path = new BigInteger[5];
            path[0] = BigInteger.Parse(Console.ReadLine());
            path[1] = BigInteger.Parse(Console.ReadLine());
            path[2] = BigInteger.Parse(Console.ReadLine());
            path[3] = BigInteger.Parse(Console.ReadLine());
            path[4] = BigInteger.Parse(Console.ReadLine());

            BigInteger mn = 1000000000000000;
            int mnIndex = 0;
            for (var i = 0; i < 5; ++i) {
                if (mn >= path[i]) 
                {
                    mn = path[i];
                    mnIndex = i;
                }
            }

            var criticalPath = N%path[mnIndex] == 0 ? N/path[mnIndex] : N / path[mnIndex]+1;

            // 1+3+3
            criticalPath += mnIndex + BigInteger.Max(0, 4-mnIndex);

            Console.WriteLine(criticalPath);
        }
    }
}
