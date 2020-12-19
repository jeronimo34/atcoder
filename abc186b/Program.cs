using System;
using System.Collections.Generic;
using System.Linq;

namespace abc186b
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            var H = inputs[0];
            var W = inputs[1];

            int[,] G = new int[H, W];
            int mnval = 101;
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < H; ++i)
            {
                var inputs2 = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

                for (int j = 0; j < W; ++j)
                {
                    G[i, j] = inputs2[j];
                    mnval = Math.Min(mnval, inputs2[j]);
                }
            }

            int res = 0;
            for (int i = 0; i < H; ++i)
            {
                for (int j = 0; j < W; ++j)
                {
                    res += G[i, j] - mnval;
                }
            }

            Console.WriteLine(res);
        }
    }
}
