using System;
using System.Collections.Generic;
using System.Linq;

namespace abc117c
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var (N, M) = (inputs[0], inputs[1]);
            var X = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

            X.Sort();
            
            List<int> distance = new List<int>();

            for (int i = 1; i < M; ++i) {
                distance.Add(X[i] - X[i - 1]);
            }

            distance = distance.OrderByDescending(x=>x).ToList();

            var res = distance.Sum();

            var M2 = Math.Min(N - 1, M-1);

            for (int i = 0; i < M2; ++i) {
                res -= distance[i];
            }

            Console.WriteLine(res);
        }
    }
}
