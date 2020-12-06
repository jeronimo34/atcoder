using System;
using System.Collections.Generic;

namespace arc078b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] visited;
            int N;
            N = int.Parse(Console.ReadLine());
            List<int>[] paths = new List<int>[N];

            for (var i = 0; i < N; ++i) {
                paths[i] = new List<int>();
            }

            visited = new int[N];
            Array.Fill(visited, 0);


            for (var i = 0; i < N - 1; ++i)
            {
                var inputs = Console.ReadLine().Split(' ');
                var a = int.Parse(inputs[0]) - 1;
                var b = int.Parse(inputs[1]) - 1;

                paths[a].Add(b);
                paths[b].Add(a);

            }

            visited[0] = 1;
            var fncDists = new int[N];
            Dfs(0, N, visited, paths, fncDists, 0);

            Array.Fill(visited, 0);
            var snkDists = new int[N];
            Dfs(N-1, N, visited, paths, snkDists, 0);

            var res = 0;
            for (var i = 0; i < N; ++i) 
            {
                if (fncDists[i] <= snkDists[i]) res++;
            }
            
            if (2*res > N)
            {
                Console.WriteLine("Fennec");
            }
            else
            {
                Console.WriteLine("Snuke");
            }
        }

        static void Dfs(int v, int N, int[] visited, List<int>[] paths, int[] dists, int dist)
        {
            dists[v] = dist;
            visited[v] = 1;
            
            //Console.WriteLine(string.Format("v:{0} dist:{1}",v,dist));

            foreach (var v2 in paths[v]) {
                if (visited[v2] == 1) continue;
                Dfs(v2, N, visited, paths, dists, dist + 1);
            }
        }
    }
}
