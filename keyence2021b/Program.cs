using System;
using System.Collections.Generic;
using System.Linq;

namespace keyence2021b
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            var (N, K) = (inputs[0], inputs[1]);
            var a = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

            var s = new long[N+1];

            for (int i = 0; i < N; ++i)
            {
                s[a[i]] = Math.Min(s[a[i]] + 1, K);
            }

            long res = 0;
            
            for (int i = 0; i < N; ++i) 
            {
                if (s[i] < K) 
                {
                    res += (K - s[i])*i;
                    K = s[i];
                }

                if (K == 0) 
                {
                    break;
                } 
            }

            Console.WriteLine(res);
        }
    }
}
