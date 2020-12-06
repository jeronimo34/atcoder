using System;
using System.Linq;

namespace abc122c
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int N = inputs[0];
            int Q = inputs[1];
            char[] S = Console.ReadLine().ToCharArray();

            int[] a = new int[N];
            for (int i = 0; i < N-1; ++i) 
            {
                if(S[i] == 'A' && S[i+1] == 'C') a[i+1] = 1;
            }

            int[] sum = new int[N + 1];
            for (int i = 0; i < N; ++i) sum[i + 1] = sum[i] + a[i];

            for (int i = 0; i < Q; ++i) {
                inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                var l = inputs[0];
                var r = inputs[1];
                Console.WriteLine(sum[r] - sum[l]);
            }
        }
    }
}
