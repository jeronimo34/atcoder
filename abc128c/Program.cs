using System;
using System.Collections.Generic;
using System.Linq;

namespace abc128c
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var (N, M) = (inputs[0],inputs[1]);

            List<int>[] s = new List<int>[M];

            for (var i = 0; i < M; ++i)
            {
                inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)-1).ToArray();
                var k = inputs[0]+1;
                s[i] = new List<int>();
                for (var j = 1; j <= k; ++j)
                {
                    s[i].Add(inputs[j]);
                }
            }

            var p = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            var res = 0;
            for (int bit = 0; bit < (1 << N); ++bit) {
                var switches = new bool[N];

                for (var i = 0; i < N; ++i)
                {
                    if ((bit & (1 << i)) > 0) {
                        switches[i] = true;
                    }
                }

                var allon = true;
                for (var i = 0; i < M; ++i) {
                    allon &= (s[i].Where(x => switches[x]).Count() % 2 == p[i]);
                }
                if (allon) res++;
            }

            Console.WriteLine(res);
        }
    }
}
