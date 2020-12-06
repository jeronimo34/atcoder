using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC075C
{
    class Program
    {
        static int[,] graph;

        class Link {
            public int v1, v2;
        }

        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var N = inputs[0];
            var M = inputs[1];
            graph = new int[N, N];

            List<Link> links = new List<Link>();

            for (int i = 0; i < N; ++i) for (int j = 0; j < N; ++j)
                {
                    graph[i, j] = 0;
                }

            var bridgeCount = 0;
            for (int i = 0; i < M; ++i) 
            {
                inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                var a = inputs[0]-1;
                var b = inputs[1]-1;
                graph[a, b] = graph[b, a] = 1;
                links.Add(new Link() { v1 = a, v2 = b });
            }

            links.ForEach(x => 
            {
                //無視する頂点を選択
                Console.WriteLine(string.Format("削除するリンク({0}, {1})",x.v1+1, x.v2+1));

                bool[] visited = new bool[N];
                Array.Fill(visited, false);
                visited[0] = true;
                int res = Dfs(0, N, visited, x);

                if (res > 0)
                {
                    bridgeCount++;
                }
            });

            
            Console.WriteLine(bridgeCount);
        }

        static void Dfs(int v, int N, bool[] visited) 
        {
            if (visited.All(x => x == true)) return 1;

            int res = 0;

            for (int i = 0; i < N; ++i) 
            {
                if (graph[v, i] == 0) continue;
                if (visited[i]) continue;
                
                if ((v == removedLink.v1 && i == removedLink.v2) ||
                    (v == removedLink.v2 && i == removedLink.v1)) continue;
                
                //visited[i] = true;
                Dfs(i, N, visited, removedLink);
                //visited[i] = false;            
            }

            return res;
        }
    }
}
