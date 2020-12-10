using System;
using System.Linq;

namespace abc152c
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var P = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            long res = 0;
            long mn = 200001;
            for (int i = 0; i < N; ++i) {
                if (P[i] < mn) {
                    mn = P[i];
                    res++;
                }
            }
            Console.WriteLine(res);
        }
    }
}
