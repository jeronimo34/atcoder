using System;
using System.Collections.Generic;
using System.Linq;

namespace abc188c
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

            long n = 1;
            for (int i = 0; i < N; ++i) n *= 2;
            var G = new List<Tuple<int, long>>();
            for (int i = 0; i < n; ++i) G.Add(new Tuple<int, long>(i, A[i]));

            while (G.Count() > 2)
            {
                var tmpG = new List<Tuple<int, long>>();
                for (int i = 0; i < G.Count - 1; i+=2)
                {
                    if (G[i].Item2 > G[i + 1].Item2)
                    {
                        tmpG.Add(G[i]);
                    }
                    else
                    {
                        tmpG.Add(G[i + 1]);
                    }
                }
                G = tmpG;
            }

            if (G[0].Item2 > G[1].Item2)
            {
                Console.WriteLine(G[1].Item1 + 1);
            }
            else {
                Console.WriteLine(G[0].Item1 + 1);
            }
        }
    }
}
