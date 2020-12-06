using System;
using System.Linq;

namespace arc086a
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] inputs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            long N = inputs[0];
            long K = inputs[1];
            long[] A = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

            long[] s = new long[N + 1];

            Array.Fill(s, 0);

            for (int i = 0; i < N; ++i) {
                s[A[i]]++;
            }

            Array.Sort(s);

            long res = 0;// s.Sum();
            int k = s.Where(x => x != 0).Count();

            for (int i = 0; i < N; ++i) {
                if (s[i] == 0) continue;
                if (k <= K) break;
                res += s[i];
                k--;
            }

            Console.WriteLine(res);
        }
    }
}
