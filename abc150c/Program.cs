using System;
using System.Collections.Generic;

namespace abc150c
{
    class Program
    {
        static bool[] visited;
        static List<Tuple<double, double>> points = new List<Tuple<double, double>>();
        static int N;
        static double sum = 0;

        static string P;
        static string Q;

        static List<string> permutations = new List<string>();


        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());

            visited = new bool[N];
            P = Console.ReadLine().Replace(" ","");
            Q = Console.ReadLine().Replace(" ", "");


            Dfs(0, "");
            permutations.Sort();

            var a = permutations.IndexOf(P);
            var b = permutations.IndexOf(Q);

            Console.WriteLine(Math.Abs(a - b));
        }

        static void Dfs(int depth, string num)
        {
            /*
            for (var i = 0; i < depth; ++i) Console.Write("\t");
            Console.WriteLine(num.ToString());
            */

            if (depth == N)
            {
                permutations.Add(num);
                return;
            }

            for (var i = 0; i < N; ++i)
            {
                if (visited[i]) continue;

                visited[i] = true;

                if (depth == 0) Dfs(1, (i+1).ToString());
                else
                {
                    Dfs(depth + 1, num+(i+1).ToString());
                }
                visited[i] = false;
            }
        }
    }
}
