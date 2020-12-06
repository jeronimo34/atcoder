using System;
using System.Linq;
using System.Numerics;

namespace abc169b
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            BigInteger[] A = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();

            BigInteger res = 1;

            if (A.Contains(0)) {
                Console.WriteLine(0);
                return;
            }

            for (var i = 0; i < N; ++i) {
                res *= A[i];
                if (res > 1000000000000000000)
                {
                    Console.WriteLine(-1);
                    return;
                }
            }
            
            Console.WriteLine(res);
        }
    }
}
