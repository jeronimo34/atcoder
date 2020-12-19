using System;
using System.Linq;

namespace abc186d
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long[] A = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

            Array.Sort(A);
            
            long[] S = new long[N];
            S[0] = A[0];
            for (int i = 1; i < N; ++i) S[i] = A[i] + S[i - 1];
            
            long res = 0;
            for (int i = 0; i < N; ++i) 
            {
                res += (S[N-1] - S[i]) - (N-i-1)*A[i];
            }

            Console.WriteLine(res);
        }
    }
}
