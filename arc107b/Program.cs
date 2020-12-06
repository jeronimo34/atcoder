using System;
using System.Linq;

namespace arc107b
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            var N = inputs[0];
            var K = inputs[1];
            long res = 0;

            for (var x = 2; x <= 2*N; ++x) 
            {
                var abres = Min(x - 1, 2 * N + 1 - x);
                var cdres = Min((x - K) - 1, 2 * N + 1 - (x - K));

                if (abres * cdres <= 0) continue;
                res += abres * cdres;
            }

            Console.WriteLine(res);
        }

        static long Min(long a, long b) {
            return (a > b) ? b : a;
        }
    }
}
