using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace s8pc_6_b
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger N = BigInteger.Parse( Console.ReadLine());

            List<BigInteger> A = new List<BigInteger>();
            List<BigInteger> B = new List<BigInteger>();
            List<BigInteger> A2 = new List<BigInteger>();
            List<BigInteger> B2 = new List<BigInteger>();

            for (var i = 0; i < N; ++i) 
            {
                BigInteger[] inputs = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();
                BigInteger a = inputs[0];
                BigInteger b = inputs[1];
                A.Add(a);
                A2.Add(a);

                B.Add(b);
                B2.Add(b);
            }

            A.Sort();
            B.Sort();

            var enterPos = A[A.Count / 2];
            var exitPos = B[B.Count / 2];

            BigInteger res = 0;

            for (var i = 0; i < N; ++i) 
            {
                //S->A->B->G
                var tmp = Abs(enterPos - A2[i]) + Abs(B2[i] - A2[i]) + Abs(exitPos - B2[i]);

                //S->B->A->G
                var tmp2 = Abs(enterPos - B2[i]) + Abs(B2[i] - A2[i]) + Abs(exitPos - A2[i]);

                res += Min(tmp,tmp2);
            }

            Console.WriteLine(res);
        }

        public static BigInteger Abs(BigInteger a)
        {
            return a < 0 ? -a : a;
        }
        public static BigInteger Min(BigInteger a, BigInteger b)
        {
            return a > b ? b : a;
        }


    }
}
