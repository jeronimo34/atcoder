using System;
using System.Linq;

namespace ABC054C
{
    class Program
    {
        static int[,] graph;

        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ');
            var N = int.Parse(inputs[0]);
            var M = int.Parse(inputs[1]);
            var visited = new bool[N]; //頂点を訪れたかどうか
            Array.Fill(visited, false);
            graph = new int[N, N];

            for (var i = 0; i < N; ++i)            
                for (var j = 0; j < N; ++j) graph[i, j] = 0;

            for (var i = 0; i < M; ++i) 
            { 
                inputs = Console.ReadLine().Split(' ');
                var a = int.Parse(inputs[0])-1;
                var b = int.Parse(inputs[1])-1;
                graph[a, b] = graph[b, a] = 1;
            }

            visited[0] = true;
            var res = DFS(0, N, visited);

            Console.WriteLine(res);
        }

        static int DFS(int v, int N, bool[] visited) 
        {

            if (visited.All(x => x == true)) 
            {
                return 1;
            }

            var res = 0;

            for (var i = 0; i < N; ++i) 
            {
                if (graph[v, i] == 0) continue;
                if (visited[i]) continue;

                visited[i] = true;
                res += DFS(i, N, visited);
                visited[i] = false;
            }

            return res;
        }
    }
}
