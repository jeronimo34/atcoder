using System;
using System.Collections.Generic;
using System.Linq;

namespace abc173c
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int H = inputs[0];
            int W = inputs[1];
            int K = inputs[2];

            var G = new char[H, W];

            for (int i = 0; i < H; ++i) {
                var s = Console.ReadLine();
                for (int j = 0; j < W; ++j) {
                    G[i, j] = s[j];
                }
            }

            var Hs = new List<List<int>>();
            var Ws = new List<List<int>>();

            //bit全探索
            for (int bit = 0; bit < (1 << H); ++bit)
            {
                var S = new List<int>();
                for (int i = 0; i < H; ++i)
                {
                    if ((bit & (1 << i)) > 0)
                    { // 列挙に i が含まれるか
                        S.Add(i);
                    }
                }
                Hs.Add(S);
            }

            //bit全探索
            for (int bit = 0; bit < (1 << W); ++bit)
            {
                var S = new List<int>();
                for (int i = 0; i < W; ++i)
                {
                    if ((bit & (1 << i)) > 0)
                    { // 列挙に i が含まれるか
                        S.Add(i);
                    }
                }
                Ws.Add(S);
            }

            var res = 0;
            for (var i = 0; i < Hs.Count; ++i) {
                for (var j = 0; j < Ws.Count; ++j) {

                    var tres = 0;
                    for (var y = 0; y < H; ++y) 
                    {
                        if (Hs[i].Contains(y)) continue;
                     
                        for (var x = 0; x < W; ++x) 
                        {
                            if (Ws[j].Contains(x)) continue;
                            if (G[y, x] == '#') tres++;
                        }
                    }
                    if (tres == K) res++;
                }
            }

            Console.WriteLine(res);

        }
    }
}
