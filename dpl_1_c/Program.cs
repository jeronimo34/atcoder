using System;
using System.Linq;

namespace dpl_1_c
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var N = inputs[0];
            var W = inputs[1];

            var value = new int[N];
            var weight = new int[N];

            for (var i = 0; i < N; ++i)
            {
                inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                var v = inputs[0];
                var w = inputs[1];

                value[i] = v;
                weight[i] = w;
            }

            //i番目までの品物の中から重さがwを超えないように選んだときの、価値の総和の最大値
            var dp = new int[N+1, W+1];
            for (var w = 0; w <= W; ++w) dp[0, w] = 0;

            for (var i = 0; i < N; ++i)
            {
                for (var w = 0; w <= W; ++w)
                {
                    if (w - weight[i] >= 0) dp[i + 1, w] = Math.Max(dp[i, w], dp[i, w - weight[i]] + value[i]);
                    else dp[i + 1, w] = dp[i, w];
                }
            }

            Console.WriteLine(dp[N,W]);
        }
    }
}
