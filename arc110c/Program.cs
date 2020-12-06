using System;
using System.Collections.Generic;
using System.Linq;

namespace arc110c
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var P = Console.ReadLine().Split(' ').Select(x => int.Parse(x)-1).ToArray();

            int num = 0;
            List<long> ans = new List<long>();

            for (int i = 0; i < N; ++i) 
            {
                if (P[i] != num) continue;
                for (int j = i; j > num; j--) 
                {
                    (P[j], P[j - 1]) = (P[j - 1], P[j]);
                    ans.Add(j);
                }
                num = i;
            }

            for (int i = 0; i < N; ++i) {
                if (P[i] != i) {
                    Console.WriteLine(-1);
                    return;
                }
            }

            if (ans.Count() != N-1) 
            {
                Console.WriteLine(-1);
                return;
            }

            ans.ForEach(x => {
                Console.WriteLine(x);
            });
        }
    }
}
