using System;
using System.Linq;

namespace agc049a
{
    class Program
    {
        static bool[] visited;
        static int N;
        static int[,] G;
        static double res = 0;

        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            G = new int[N, N];

            for (var i = 0; i < N; ++i)
            {
                var S = Console.ReadLine();//.Split(' ').Select(x => double.Parse(x)).ToArray();

                for (var j = 0; j < N; ++j) {
                    G[i,j] = int.Parse(S[j].ToString());
                }
            }

            for (var i = 0; i < N; ++i) {
                visited = new bool[N];
                Dfs2(i);
            }

            Console.WriteLine(res/N);

        }

        static void Dfs2(int v) {
            if (!visited.All(x => x))
            {
                for (var nv = 0; nv < N; ++nv)
                {
                    if (visited[nv]) continue;

                    visited[nv] = true;
                    Dfs(nv);
                    visited[nv] = false;
                }
            }
        }

        static void Dfs(int v) 
        {
            visited[v] = true;

            for (var nv = 0; nv < N; ++nv) {
                if (visited[nv]) continue;
                if (G[v, nv] == 0) continue;
                Dfs(nv);
            }
        }
    }
}
