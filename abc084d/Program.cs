using System;
using System.Linq;

namespace abc084d
{
    class Program
    {
        static void Main(string[] args)
        {
            int Q = int.Parse(Console.ReadLine());

            var L = new int[Q];
            var R = new int[Q];

            for (int i = 0; i < Q; ++i) 
            {
                var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                var l = inputs[0];
                var r = inputs[1];

                L[i] = l;
                R[i] = r;
            }

            bool[] isPrime = new bool[100001];
            Array.Fill(isPrime, true);
            isPrime[0] = isPrime[1] = false;
            for (int i = 2; i < 100001; ++i) {
                if (!isPrime[i]) continue;
                for (int j = i * 2; j < 100001; j += i) isPrime[j] = false;
            }

            int[] like2017 = new int[100001];
            for (int i = 0; i < 100001; ++i) {
                if (isPrime[i] && isPrime[(i + 1) / 2]) like2017[i] = 1;
            }

            int[] sum = new int[100002];
            for (int i = 0; i < 100001; ++i)
            {
                sum[i+1] = sum[i] + like2017[i]; 
            }

            for (int i = 0; i < Q; ++i)
            {
                var l = L[i];
                var r = R[i];
                Console.WriteLine(sum[r+1] - sum[l]);
            }
        }
    }
}
