using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var line1 = Console.ReadLine();
            var N = int.Parse(line1);
            var line2 = Console.ReadLine();
            var inputs = line2.Split(' ');

            //N = 200000;
            var array = new int[N];


            for (var i = 0; i < N; ++i) {
                array[i] =  int.Parse(inputs[i]);
            }


            var res = new int[N];
            var pool = new int[200002];
            for (var i = 0; i < 200002; ++i) pool[i] = 200001;

            int minval = 0;

            for (var i = 0; i < N; ++i) {
                pool[i] = i;

                if (array[i] == minval)
                {
                    var min = pool.Min();
                    pool[min] = 200001;
                    min = pool.Min();
                    minval = min;
                }
                res[i] = minval;
            }

            for (var i = 0; i < N; ++i) Console.WriteLine(res[i]);
        }

        void SolveB() {
            var line = Console.ReadLine();
            var inputs = line.Split(' ');

            var H = int.Parse(inputs[0]);
            var W = int.Parse(inputs[1]);

            var map = new char[H, W];


            for (var i = 0; i < H; ++i)
            {
                var s = Console.ReadLine();

                for (var j = 0; j < W; ++j)
                {
                    map[i, j] = s[j];
                }
            }


            var dy = new int[] { 1, 0, -1, 0 };
            var dx = new int[] { 0, 1, 0, -1 };
            var res = 0;
            for (var i = 0; i < H; ++i)
            {
                for (var j = 0; j < W; ++j)
                {
                    for (var k = 0; k < 4; ++k)
                    {
                        var ty = i + dy[k];
                        var tx = j + dx[k];

                        if (ty < 0 || H <= ty) continue;
                        if (tx < 0 || W <= tx) continue;

                        if (map[i, j] == '.' && map[ty, tx] == '.') res++;
                    }
                }
            }

            Console.WriteLine(res / 2);
        }

        void SolveA() {
            var S = Console.ReadLine();
            var T = Console.ReadLine();

            if (S == "Y") Console.WriteLine(T.ToUpper());
            else Console.WriteLine(T);
        }
    }
}
