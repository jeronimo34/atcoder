using System;
using System.Linq;
using System.Numerics;

namespace abc184c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solve());

        }

        static int solve()
        {
            BigInteger[] inputs = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();
            BigInteger r1 = inputs[0];
            BigInteger c1 = inputs[1];

            inputs = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();
            BigInteger r2 = inputs[0];
            BigInteger c2 = inputs[1];

            //0回
            if (r1 == r2 && c1 == c2)
            {
                return 0;
            }

            //1回
            if ((r1 + c1 == r2 + c2) ||
                (r1 - c1 == r2 - c2) ||
                (BigInteger.Abs(r1 - r2) + BigInteger.Abs(c1 - c2) <= 3))
            {
                return 1;
            }

            //2回
            if ((r1 + c1)%2 == (r2 + c2)%2) return 2;
            if (BigInteger.Abs(r1 + c1 - (r2 + c2)) <= 3) return 2;
            if (BigInteger.Abs(r1 - c1 - (r2 - c2)) <= 3) return 2;
            if (BigInteger.Abs(r1 - r2) + BigInteger.Abs(c1 - c2) <= 6) return 2;

            return 3;
        }
    }
}
