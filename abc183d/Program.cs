using System;
using System.Collections.Generic;
using System.Linq;

namespace abc183d
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var N = inputs[0];
            var W = inputs[1];

            int MAX = 200001;
            long[] table = new long[MAX];

            for (var i = 0; i < N; ++i)
            {
                inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                var s = inputs[0];
                var t = inputs[1];
                var p = inputs[2];
                table[s] += p;
                table[t] -= p;
            }

            long[] sum = new long[MAX+1];

            for (int i = 0; i < MAX; ++i) {
                sum[i + 1] = sum[i] + table[i];
            }

            if (sum.Max() > W)
            {
                Console.WriteLine("No");
            }
            else {
                Console.WriteLine("Yes");
            }
        }
    }
}
