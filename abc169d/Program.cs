using System;
using System.Collections.Generic;

namespace abc169d
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = long.Parse(Console.ReadLine());

            if (N == 1) {
                Console.WriteLine(0);
                return;
            }

            List<long> div = new List<long>();

            div.Add(N);
            for (long i = 2; i * i <= N; ++i) {
                if (N % i == 0) {
                    div.Add(i);
                    if (i * i != N) div.Add(N / i);
                }
            }
            div.Sort();

            long res = 0;
            for (int i = 0; i < div.Count; ++i) {
                if (N % div[i] == 0) {
                    N = N / div[i];
                    res++;
                }
            }

            Console.WriteLine(res);
        }

    }
}
