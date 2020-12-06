using System;
using System.Collections;
using System.Collections.Generic;

namespace abc088d
{
    class Program
    {
        static char[,] graph;
        static long[,] dist;
        static long W, H;

        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ');
            H = long.Parse(inputs[0]);
            W = long.Parse(inputs[1]);
            graph = new char[H, W];
            dist = new long[H, W];
            var wallCount = 0;
            
            for (var i = 0; i < H; ++i) {
                var s = Console.ReadLine();
                for (var j = 0; j < W; ++j) {
                    graph[i, j] = s[j];
                    if (s[j] == '#') wallCount++;
                    dist[i, j] = -1;//未訪問に初期化
                }
            }

            //BFS
            Queue queue = new Queue();
            var tuple = new Tuple<long, long>(0, 0);
            dist[0, 0] = 0;
            queue.Enqueue(tuple);

            while (queue.Count != 0)
            { 
                var v = queue.Dequeue() as Tuple<long,long>;

                var y = v.Item1;
                var x = v.Item2;
                var tx = new int[] { 0, 1, 0, -1 };
                var ty = new int[] { 1, 0, -1, 0 };

                for (var i = 0; i < 4; ++i)
                {
                    var ny = y + ty[i];
                    var nx = x + tx[i];

                    if (nx < 0 || W <= nx) continue;
                    if (ny < 0 || H <= ny) continue;
                    if (graph[y + ty[i], x + tx[i]] == '#') continue;
                    if (dist[ny, nx] != -1) continue;

                    dist[ny, nx] = dist[y, x] + 1;
                    queue.Enqueue(new Tuple<long,long>(ny, nx));
                }

            }


            if (dist[H - 1, W - 1] == -1)
            {
                Console.WriteLine("-1");
            }
            else 
            {
                var res = H*W - wallCount - dist[H-1, W-1]-1;
                Console.WriteLine(res);
            }
        }

    }
}
