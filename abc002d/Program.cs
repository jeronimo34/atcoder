using System;
using System.Collections.Generic;
using System.Linq;

namespace abc002d
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var N = inputs[0];
            var M = inputs[1];

            var G = new bool[N, N];

            for (var i = 0; i < M; ++i)
            {
                inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)-1).ToArray();
                var x = inputs[0];
                var y = inputs[1];
                G[y, x] = G[x, y] = true;
            }

            for (var i = 0; i < N; ++i) G[i, i] = true;

            var res = -99999;
            for (int bit = 0; bit < (1 << N); ++bit)
            {
                List<int> list = new List<int>();
                for (int i = 0; i < N; ++i)
                {
                    if ((bit & (1 << i)) > 0)
                    { // 列挙に i が含まれるか
                        list.Add(i);
                    }
                }

                if (list.Count == 0) continue;

                var isHabatu = true;

                for (var i = 0; i < list.Count; ++i) 
                {
                    var v = list[i];
                    for (var j = 0; j < list.Count; ++j) 
                    {
                        var v2 = list[j];
                        if (G[v, v2] == false) {
                            isHabatu = false;
                            break;
                        }
                    }
                }

                if (isHabatu) {
                    res = Math.Max(res, list.Count);
                }
            }

            Console.WriteLine(res);
        }
    }
}
