using System;
using System.Linq;

namespace abc073d
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ');
            var N = int.Parse(inputs[0]);
            var M = int.Parse(inputs[1]);
            var R = int.Parse(inputs[2]);

            var Rs = Console.ReadLine().Split(' ').Select(x => int.Parse(x) - 1).ToArray();

            var INF = 1000000000;
            var d = new int[N, N];

            for (var i = 0; i < N; ++i)
            {
                for (var j = 0; j < N; ++j)
                {
                    d[i, j] = INF;
                }
            }

            for (var i = 0; i < M; ++i)
            {
                inputs = Console.ReadLine().Split(' ');
                var a = int.Parse(inputs[0]) - 1;
                var b = int.Parse(inputs[1]) - 1;
                var c = int.Parse(inputs[2]);
                d[a, b] = d[b, a] = c;
            }

            //ワーシャルフロイド i->jの最短経路
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

            var res = INF;
            for (var i = 0; i < Rs.Length; ++i)
            {
                var visited = new bool[N];
                visited[Rs[i]] = true;
                res = Math.Min(res, Dfs(Rs[i], visited, Rs, d, 0));
            }

            Console.WriteLine(res);
        }

        static int Dfs(int v, bool[] visited, int[] Rs, int[,] d, int cost)
        {
            var allvisited = true;
            for (var i = 0; i < Rs.Length; ++i)
            {
                if (!visited[Rs[i]])
                {
                    allvisited = false;
                    break;
                }
            }
            if (allvisited)
            {
                return cost;
            }

            var INF = 1000000000;
            var res = INF;
            for (var i = 0; i < Rs.Length; ++i)
            {
                var v2 = Rs[i];
                if (visited[v2]) continue;
                visited[v2] = true;
                res = Math.Min(res, Dfs(v2, visited, Rs, d, cost + d[v, v2]));
                visited[v2] = false;
            }

            return res;
        }
    }
}