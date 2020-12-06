using System;
using System.Linq;

namespace abc129c
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var (N, M) = (inputs[0], inputs[1]);

            long[] s = new long[N+1];
            s[0] = 1;
            s[1] = 1;

            bool[] broken = new bool[N + 1];

            for (int i = 0; i < M; ++i) {
                var a = int.Parse(Console.ReadLine());
                broken[a] = true;
            }

            const long mod = 1000000007;

            for (int i = 2; i <= N; ++i) {
                if (broken[i]) continue;
                if (broken[i - 2] == false) s[i] += s[i - 2];
                if (broken[i - 1] == false) s[i] += s[i - 1];
                s[i] %= mod;
            }

            Console.WriteLine(s[N]%mod);
        }
    }
}
