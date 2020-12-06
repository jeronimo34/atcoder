using System;
using System.Collections.Generic;
using System.Linq;

namespace abc160c
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] inputs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            long K = inputs[0];
            long N = inputs[1];
            List<long> A = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToList();

            A.Add(K + A[0]);

            long mx = 0;
            long sum = 0;

            for (int i = 0; i < A.Count - 1; ++i) {
                sum += A[i + 1] - A[i];

                if (mx < A[i + 1] - A[i]) {
                    mx = A[i + 1] - A[i];
                }
            }

            Console.WriteLine(sum - mx);
        }
    }
}
