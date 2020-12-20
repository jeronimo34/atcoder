using System;

namespace abc144c
{
    class Program
    {
        static void Main(string[] args)
        {
            long N =long.Parse(Console.ReadLine());

            long res = 1000000000000;
            for (long i = 1; i * i <= N; ++i) {
                if (N % i != 0) continue;
                res = Math.Min(res, i+N/i-2);
            }
            Console.WriteLine(res);
        }
    }
}
