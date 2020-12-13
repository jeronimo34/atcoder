using System;
using System.Collections.Generic;
using System.Linq;

namespace abc185d
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            var N = inputs[0];
            var M = inputs[1];
            var str = Console.ReadLine();

            if (M == 0) 
            {
                Console.WriteLine(1);
                return;
            }

            var A = str.Split(' ').Select(x => long.Parse(x)).ToList();
            A.Add(0);
            A.Add(N + 1);
            A.Sort();

            List<long> W = new List<long>();
            for (int i = 0; i < A.Count-1; ++i) 
            {
                if (A[i + 1] - A[i] - 1 > 0) {
                    W.Add(A[i + 1] - A[i] - 1);
                }
            }

            if (W.Count == 0) {
                Console.WriteLine(0);
                return;
            }

            var k = W.Min();
            long res = 0;
            for (int i = 0; i < W.Count; ++i) 
            {
                res += W[i] / k;
                if (W[i] % k != 0) res++;
            }

            Console.WriteLine(res);
        }
    }
}