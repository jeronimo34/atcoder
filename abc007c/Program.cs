using System;
using System.Collections.Generic;
using System.Linq;

namespace abc007c
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var R = inputs[0];
            var C = inputs[1];

            inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x) - 1).ToArray();
            var SY = inputs[0];
            var SX = inputs[1];

            inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x) - 1).ToArray();

            var GY = inputs[0];
            var GX = inputs[1];
            var G = new char[R, C];
            var dist = new int[R, C];

            for (var i = 0; i < R; ++i)
            {
                var line = Console.ReadLine();
                for (var j = 0; j < C; ++j)
                {
                    G[i, j] = line[j];
                    dist[i, j] = -1;
                }
            }

            Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
            queue.Enqueue(new Tuple<int, int>(SY, SX));
            dist[SY, SX] = 0;

            var dy = new int[] { 0, 1, 0, -1 };
            var dx = new int[] { 1, 0, -1, 0 };
            var res = 0;

            while (queue.Count > 0)
            {
                var v = queue.Dequeue();

                if (v.Item1 == GY && v.Item2 == GX)
                {
                    res = dist[v.Item1, v.Item2];
                    break;
                }

                for (var i = 0; i < 4; ++i)
                {
                    var ny = v.Item1 + dy[i];
                    var nx = v.Item2 + dx[i];

                    if (ny < 0 || R <= ny) continue;
                    if (nx < 0 || C <= nx) continue;
                    if (G[ny, nx] == '#') continue;
                    if (dist[ny, nx] != -1) continue;

                    queue.Enqueue(new Tuple<int, int>(ny, nx));
                    dist[ny, nx] = dist[v.Item1, v.Item2] + 1;
                }
            }

            Console.WriteLine(res);
        }
    }
}
