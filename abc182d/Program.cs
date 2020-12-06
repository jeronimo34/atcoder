using System;
using System.Linq;
using System.Numerics;

namespace abc182d
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();

            BigInteger[] p = new BigInteger[N];//合計座標の変化
            BigInteger[] q = new BigInteger[N];//座標の最大値

            p[0] = A[0];
            q[0] = A[0];
            var sum = A[0];

            for (int i = 1; i < N; ++i)
            {
                sum += A[i];
                p[i] = p[i-1]+sum;
                q[i] = Max(q[i-1], sum);
            }

            BigInteger r = q[0];

            for (var i = 1; i < N; ++i) 
            {
                r = Max(r, p[i-1] + q[i]);            
            }

            Console.WriteLine(Max(r,0));
        }

        static BigInteger Max(BigInteger a, BigInteger b) {
            return a > b ? a : b;
        }
    }
}
