using System;
using System.Linq;

namespace abc012d
{
    class Program
    {
        static readonly long INF = 1000000000;

        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var N = inputs[0];
            var M = inputs[1];
            var d = new long[N, N];

            for (var i = 0; i < N; ++i)
            {
                for (var j = 0; j < N; ++j)
                {
                    d[i, j] = INF;
                }
            }

            for (var i = 0; i < M; ++i)
            {
                inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                var v1 = inputs[0] - 1;
                var v2 = inputs[1] - 1;
                var t = inputs[2];
                d[v1, v2] = d[v2, v1] = t;
            }

            for (var i = 0; i < N; ++i) d[i, i] = 0;

            var res = new long[N];

            //ワーシャルフロイド
            for (var k = 0; k < N; ++k)
            {
                for (var i = 0; i < N; ++i)
                {
                    for (var j = 0; j < N; ++j)
                    {
                        if (d[i, j] > d[i, k] + d[k, j])
                        {
                            d[i, j] = d[i, k] + d[k, j];
                        }
                    }
                }
            }

            for (var i = 0; i < N; ++i)
            {
                for (var j = 0; j < N; ++j)
                {
                    res[i] = Math.Max(res[i], d[i, j]);
                }
            }

            Console.WriteLine(res.Min());
        }
    }
}
