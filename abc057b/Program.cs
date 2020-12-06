using System;
using System.Linq;
using System.Numerics;

namespace abc057b
{
    class Program
    {
        class Point {
           public int x;
           public int y;
        }

        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int N = inputs[0];
            int M = inputs[1];

            Point[] students = new Point[N];
            for (int i = 0; i < N; ++i) {
                inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                var a = inputs[0];
                var b = inputs[1];
                students[i] = new Point { x = a, y = b };
            }

            Point[] targets = new Point[M];
            for (int i = 0; i < M; ++i)
            {
                inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                var c = inputs[0];
                var d = inputs[1];
                targets[i] = new Point { x = c, y = d };
            }

            for (int i = 0; i < N; ++i)
            {
                var res = 0;
                int mnmanhattan = 1000000000;
                for (int j = 0; j < M; ++j)
                {
                    int mnhattan = Math.Abs(targets[j].x - students[i].x) + Math.Abs(targets[j].y - students[i].y);
                    if (mnmanhattan > mnhattan) {
                        mnmanhattan = mnhattan;
                        res = j+1;
                    }
                }
                Console.WriteLine(res);
            }

            }
    }
}
