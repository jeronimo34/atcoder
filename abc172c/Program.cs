using System;
using System.Linq;
using System.Numerics;

namespace abc172c
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int N = inputs[0];
            int M = inputs[1];
            BigInteger K = inputs[2];

            int[] A = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int[] B = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            BigInteger[] a = new BigInteger[N+1];
            a[0] = 0;
            for (var i = 1; i <= N; ++i) 
            {
                a[i] = a[i - 1] + A[i-1];
            }

            BigInteger[] b = new BigInteger[M+1];
            b[0] = 0;
            for (var i = 1; i <= M; ++i)
            {
                b[i] = b[i - 1] + B[i-1];
            }

            int res = 0;
            int j = M;
            for (int i = 0; i <= N; ++i)
            {
                while (j >= 0 && a[i] + b[j] > K) j--;
                if (j >= 0 && a[i] + b[j] <= K) {
                    res = Math.Max(i + j, res);
                }
            }

            Console.WriteLine(res);
        }
    }
}
