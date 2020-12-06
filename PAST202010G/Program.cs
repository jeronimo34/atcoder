using System;
using System.Linq;

namespace PAST202010G
{
    class Program
    {
        static int N;
        static int M;
        static bool[,] visited;
        static char[,] graph;
        static int candidateCount = 0;

        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            N = inputs[0];
            M = inputs[1];
            graph = new char[N, M];
            visited = new bool[N, M];

            for (int i = 0; i < N; ++i)
            {
                var s = Console.ReadLine();
                for (int j = 0; j < M; ++j)
                {
                    graph[i, j] = s[j];
                }
            }

            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < M; ++j)
                {
                    if (graph[i, j] == '#')
                    {
                        //Console.WriteLine("===============");                        
                        graph[i, j] = '.';
                        InitVisited();
                        Dfs(i, j);
                        graph[i, j] = '#';
                    }
                }
            }

            Console.WriteLine(candidateCount);
        }

        static void InitVisited()
        {
            for (int i = 0; i < N; ++i)
                for (int j = 0; j < M; ++j)
                {
                    visited[i, j] = false;
                    if (graph[i, j] == '#') visited[i, j] = true;
                }
        }

        static void Dfs(int y, int x)
        {
            visited[y, x] = true;
            //Console.WriteLine(string.Format("(x,y)({0}, {1})", x+1, y+1));

            bool allvisited = true;
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < M; ++j)
                {
                    if (!visited[i, j])
                    {
                        allvisited = false;
                        break;
                    }
                }
            }

            if (allvisited)
            {
                candidateCount++;
                return;
            }

            int[] dy = new int[] { 1, 0, -1, 0 };
            int[] dx = new int[] { 0, 1, 0, -1 };
            for (int k = 0; k < 4; ++k)
            {
                var py = y + dy[k];
                var px = x + dx[k];

                if (py < 0 || N <= py) continue;
                if (px < 0 || M <= px) continue;
                if (graph[py, px] == '#') continue;
                if (visited[py, px]) continue;
                Dfs(py, px);
            }
        }
    }
}
