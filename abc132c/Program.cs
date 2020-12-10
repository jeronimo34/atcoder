using System;
using System.Linq;

namespace abc132c
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var d = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

            //Array.Sort(d);

            int[] A = new int[100001];
            for (int i = 0; i < N; ++i)
            {
                A[d[i]]++;
            }

            long sum = 0;
            long res = 0;

            for (int i = 0; i <= 100000; ++i) {
                sum += A[i];
                if (sum == N - sum) res++;
            }

            Console.WriteLine(res);
        }
    }
}
