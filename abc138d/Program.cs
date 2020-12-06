using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace abc138d
{
    class Program
    {

        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var N = inputs[0];
            var Q = inputs[1];

            var nodes = new List<int>[N];
            
            for (var i = 0; i < N; ++i) nodes[i] = new List<int>();

            for (var i = 0; i < N-1; ++i)
            {
                inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)-1).ToArray();
                var a = inputs[0];
                var b = inputs[1];
                nodes[a].Add(b);
                nodes[b].Add(a);

            }

            var counter = new long[N];
            for (var j = 0; j < Q; ++j)
            {
                inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                var p = inputs[0]-1;
                var x = inputs[1];
                counter[p] += x;
            }

            var visited = new bool[N];
            Dfs(0, nodes, counter, visited);

            Console.WriteLine(string.Join(" ", counter.Select(x=>x.ToString())));
        }

        static void Dfs(int v, List<int>[] node, long[] counter, bool[] visited) 
        {
            visited[v] = true;
            if (node[v].Count == 0) return;

            for (var i = 0; i < node[v].Count; ++i) 
            {
                if (visited[node[v][i]]) continue;
                counter[node[v][i]] += counter[v];
                Dfs(node[v][i], node, counter, visited);
            }
        }
    }
}
