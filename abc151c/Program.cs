using System;
using System.Linq;

namespace abc151c
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var N = inputs[0];
            var M = inputs[1];

            var ac = new long[N];
            var wa = new long[N];
            for (var i = 0; i < M; ++i)
            {
                var inputs2 = Console.ReadLine().Split(' ');
                var p = int.Parse(inputs2[0]) - 1;
                var s = inputs2[1];

                if (s == "AC")
                {
                    ac[p] = 1;
                }
                else if (s == "WA" && ac[p] != 1)
                {
                    wa[p]++;
                }
            }

            for (var i = 0; i < N; ++i)
            {
                if (ac[i] == 0) wa[i] = 0;
            }

            Console.WriteLine(ac.Sum() + " " + wa.Sum());
        }
    }
}
