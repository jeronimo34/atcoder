using System;
using System.Collections.Generic;
using System.Linq;

namespace abc177d
{
    class Program
    {
        static bool[] visited;
        static List<List<int>> G;
        static int res = 0;
        static int cnt = 0;
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var N = inputs[0];
            var M = inputs[1];


            G = new List<List<int>>();
            for (int i = 0; i < N; ++i) G.Add(new List<int>());

            visited = new bool[N];

            for (var i = 0; i < M; ++i)
            {
                inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)-1).ToArray();
                var a = inputs[0];
                var b = inputs[1];
                G[a].Add(b);
                G[b].Add(a);
            }

            for (int v = 0; v < N; ++v)
            {
                if (visited[v]) continue;
                cnt = 0;
                Dfs(v);
                res = Math.Max(res, cnt);
            }

            Console.WriteLine(res);
        }

        static void Dfs(int v) 
        {
            visited[v] = true;
            cnt++;

            foreach (var nv in G[v]) {
                if (visited[nv]) continue;
                Dfs(nv);
            }
        }
    }
}
