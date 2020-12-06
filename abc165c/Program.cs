using System;
using System.Collections.Generic;
using System.Linq;

namespace abc165c
{
    class Program
    {
        static int M;
        static int N;
        static int Q;
        static int[] a;
        static int[] b;
        static int[] c;
        static int[] d;
        static long res = 0;
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            (N, M, Q) = (inputs[0], inputs[1], inputs[2]);

            a = new int[Q];
            b = new int[Q];
            c = new int[Q];
            d = new int[Q];

            for (int i = 0; i < Q; ++i)
            {
                inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                (a[i], b[i], c[i], d[i]) = (inputs[0]-1, inputs[1]-1, inputs[2], inputs[3]);
            }

            List<int> A = new List<int>();
            Dfs(A, 1);

            Console.WriteLine(res);
        }

        static void Dfs(List<int> A, int v) {

            if (A.Count() == N) 
            {
                long tres = 0;
                for (int i = 0; i < Q; ++i)
                {
                    if (A[b[i]] - A[a[i]] == c[i]) tres += d[i];
                }
                res = Math.Max(tres, res);
                return;
            }

            for (int v2 = v; v2 <= M; ++v2) {
                A.Add(v2);
                Dfs(A, v2);
                A.Remove(v2);
            }
        }
    }
}
