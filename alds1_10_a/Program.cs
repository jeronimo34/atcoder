using System;

namespace alds1_10_a
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = long.Parse( Console.ReadLine());

            var d = new long[N+1];

            d[0] = d[1] = 1;
            for (var i = 2; i <= N; ++i) {
                d[i] = d[i - 1] + d[i - 2];
            }
            Console.WriteLine(d[N]);
        }
    }
}
