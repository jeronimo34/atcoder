using System;
using System.Linq;

namespace abc092c
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            A.Add(0);

            long[] S = new long[N+1];
            S[0] = Math.Abs(A[0]);
            for (int i = 1; i <= N; ++i) {
                S[i] = S[i - 1] + Math.Abs(A[i] - A[i-1]);
            }

            for (int i = 0; i < N; ++i) 
            {
                long res = 0;

                if (i-1 < 0)
                {
                    res = Math.Abs(A[i + 1]) + S[N] - S[i + 1];
                }
                else 
                {
                    res = S[i - 1] + Math.Abs(A[i - 1] - A[i + 1]) + S[N] - S[i + 1];
                }

                Console.WriteLine(res);
            }
        }
    }
}
