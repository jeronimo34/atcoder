using System;
using System.Linq;

namespace abc183c
{
    class Program
    {
        static bool[] visited;
        static long[,] G;
        static long N;
        static long K;
        static int res = 0;

        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            N = inputs[0];
            K = inputs[1];

            G = new long[N, N];

            for (var i = 0; i < N; ++i)
            {
                inputs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

                for (var j = 0; j < N; ++j) {
                    G[i,j] = inputs[j];
                }
            }

            visited = new bool[N];
            visited[0] = true;
            Dfs(0,0);

            Console.WriteLine(res);
        }

        static void Dfs(long v, long sumtime) 
        {

            if (visited.All(x => x))
            {
                if (K == sumtime+G[v,0]) res++;
                return;
            }

            for (var nv = 0; nv < N; ++nv) {
                if (visited[nv]) continue;
                if (G[v, nv] == 0) continue;

                visited[nv] = true;
                Dfs(nv, sumtime+G[v,nv]);
                visited[nv] = false;
            }
        }
    }
}
