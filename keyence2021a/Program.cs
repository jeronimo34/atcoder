using System;
using System.Linq;

namespace keyence2021a
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = long.Parse(Console.ReadLine());//.ToCharArray().ToList();
            var a = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            var b = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

            long amax = a[0];
            long[] d = new long[N];
            d[0] = a[0] * b[0];
            Console.WriteLine(d[0]);

            for (int i = 1; i < N; ++i)
            {
                amax = Math.Max(amax, a[i]);
                d[i] = Math.Max(d[i - 1], b[i] * amax);
                Console.WriteLine(d[i]);
            }
        }
    }
}
