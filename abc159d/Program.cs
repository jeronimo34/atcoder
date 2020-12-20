using System;
using System.Linq;
using System.Numerics;

namespace abc159d
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            BigInteger[] d = new BigInteger[200001];

            for (int i = 0; i < N; ++i)
            {
                d[A[i]]++;
            }

            BigInteger sum = 0;
            for (int i = 0; i < 200001; ++i) {
                var n = d[i];
                sum += n * (n - 1) / 2;
            }

            for (int i = 0; i < N; ++i)
            {
                var n = d[A[i]];
                var before = n * (n - 1) / 2;

                n = d[A[i]] - 1;
                var after = n * (n - 1) / 2;
                Console.WriteLine(sum - before + after);
            }
        }
    }
}
