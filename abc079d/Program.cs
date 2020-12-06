using System;
using System.Linq;

namespace abc079d
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var H = inputs[0];
            var W = inputs[1];

            var d = new int[10, 10];

            int INF = 10000000;
            for (var i = 0; i < 10; ++i)
            {
                for (var j = 0; j < 10; ++j)
                {
                    d[i, j] = INF;
                }
            }

            for (var i = 0; i < 10; ++i)
            {
                inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

                for (var j = 0; j < 10; ++j)
                {
                    d[i, j] = inputs[j];
                }
            }

            //ワーシャルフロイド
            for (var k = 0; k < 10; ++k)
            {
                for (var i = 0; i < 10; ++i)
                {
                    for (var j = 0; j < 10; ++j)
                    {
                        if (d[i, j] > d[i, k] + d[k, j])
                        {
                            d[i, j] = d[i, k] + d[k, j];
                        }
                    }
                }
            }

            var numCount = new int[10];

            for (var i = 0; i < H; ++i)
            {
                inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

                for (var j = 0; j < W; ++j)
                {
                    var x = inputs[j];
                    if (x == -1) continue;
                    numCount[x]++;
                }
            }

            var res = 0;

            for (var i = 0; i < 10; ++i)
            {
                res += d[i, 1] * numCount[i];
            }

            Console.WriteLine(res);
        }
    }
}
