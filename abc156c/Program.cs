using System;
using System.Linq;

namespace abc156c
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = int.Parse(Console.ReadLine());
            var X = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            long res = 1000000;
            for (int p = 1; p <= 100; ++p) {
                int tres = 0;
                for (int i = 0; i < N; ++i) {
                    tres += (X[i] - p) * (X[i] - p);
                }
                res = Math.Min(res, tres);
            }

            Console.WriteLine(res);
        }
    }
}
