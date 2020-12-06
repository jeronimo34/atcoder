using System;

namespace arc091d
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ');
            var N = long.Parse(inputs[0]);
            var K = long.Parse(inputs[1]);

            long res = 0;
            for (long b = 1; b <= N; ++b)
            {
                long bk = Math.Max(0, b - K);
                long p = N / b;
                res += p * bk;

                var r = N - p * b;
                res += Math.Max(0, r - K+1);
            }
            if (K == 0) res -= N;
            Console.WriteLine(res);
        }
    }
}
