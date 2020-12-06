using System;
using System.Collections.Generic;
using System.Linq;

namespace abc145c
{
    class Program
    {
        static bool[] visited;
        static List<Tuple<double, double>> points = new List<Tuple<double, double>>();
        static int N;
        static double sum = 0;

        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());

            for (var i = 0; i < N; ++i)
            {
                var inputs = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();
                var x = inputs[0];
                var y = inputs[1];
                points.Add(new Tuple<double, double>(x, y));
            }

            visited = new bool[N];

            Dfs(-1, -1, 0);

            double mod = 1;
            for (var i = 1; i <= N; ++i) mod *= i;

            Console.WriteLine(sum / mod);
        }

        

        static void Dfs(int v, int depth, double len) 
        {
            /*
            for (var i = 0; i < depth; ++i) Console.Write("\t");
            Console.WriteLine(v);
            */
            if (depth == N-1) 
            {
                sum += len;
                return;
            }

            for (var i = 0; i < N; ++i) 
            {
                if (visited[i]) continue;

                visited[i] = true;
                
                if (v == -1) Dfs(i, 0, 0);
                else
                {
                    double l = Math.Sqrt(Math.Pow(points[i].Item1 - points[v].Item1, 2) + Math.Pow(points[i].Item2 - points[v].Item2, 2));
                    Dfs(i, depth + 1, len + l);
                }
                visited[i] = false;
            }
        }
    }
}
