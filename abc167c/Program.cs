using System;
using System.Collections.Generic;
using System.Linq;

namespace abc167c
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int N = inputs[0];
            int M = inputs[1];
            int X = inputs[2];

            var C = new int[N];
            var A = new int[N, M];

            for (var i = 0; i < N; ++i)
            {
                inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                C[i] = inputs[0];

                for (var j = 0; j < M; ++j)
                {
                    A[i, j] = inputs[j + 1];
                }
            }

            var res = 1200001;

            //bit全探索でどの参考書を選ぶかを全列挙
            for (int bit = 0; bit < (1 << N); ++bit)
            {
                List<int> S = new List<int>();
                for (int i = 0; i < N; ++i)
                {
                    if ((bit & (1 << i)) > 0)
                    { // 列挙に i が含まれるか
                        S.Add(i);
                    }
                }

                var tres = new int[M];

                for (var i = 0; i < N; ++i)
                {
                    if (!S.Contains(i))
                    {
                        continue;
                    }

                    for (var j = 0; j < M; ++j)
                    {
                        tres[j] += A[i, j];
                    }
                }

                if (tres.All(x => x >= X)) {

                    var sum = 0;
                    for (var i = 0; i < S.Count; ++i) 
                    {
                        sum+=C[S[i]];
                    }

                    res = Math.Min(res, sum);
                }
            }

            if (res == 1200001)
            {
                Console.WriteLine(-1);
            }
            else {
                Console.WriteLine(res);
            }
        }
    }
}
