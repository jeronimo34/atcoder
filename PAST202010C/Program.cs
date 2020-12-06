using System;
using System.Linq;

namespace PAST202010C
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            var N = inputs[0];
            var M = inputs[1];
            char[,] graph = new char[N, M];
            int[,] res = new int[N, M];

            for (int i = 0; i < N; ++i) 
            {  
                var s = Console.ReadLine();
                for (int j = 0; j < M; ++j) {
                    graph[i, j] = s[j];
                    res[i, j] = 0;
                }
            }

            int[] dx = new int[] { 0,1, 1, 1,  0,-1, -1, -1, 0};
            int[] dy = new int[] { 1,1, 0,-1, -1,-1, 0, 1,0};

            for (int i = 0; i < N; ++i) {
                for (int j = 0; j < M; ++j) {

                    for (int k = 0; k < 9; ++k) {
                        var py = i + dy[k];
                        var px = j + dx[k];

                        if (px < 0 || M <= px) continue;
                        if (py < 0 || N <= py) continue;

                        if (graph[py, px] == '#') res[i, j]++;
                    }
                }
            }

            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < M; ++j)
                {
                    Console.Write(res[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
