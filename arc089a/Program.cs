using System;

namespace arc089a
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = long.Parse(Console.ReadLine());

            var X = new long[N+1];
            var Y = new long[N+1];
            var T = new long[N+1];

            X[0] = Y[0] = T[0] = 0;

            for (var i = 1; i <= N; ++i) {
                var inputs = Console.ReadLine().Split(' ');
                var t = long.Parse(inputs[0]);
                var x = long.Parse(inputs[1]);
                var y = long.Parse(inputs[2]);

                X[i] = x;
                Y[i] = y;
                T[i] = t;
            }

            for (var i = 0; i < N; ++i) {

                var ax = Abs(X[i] - X[i + 1]);
                var ay = Abs(Y[i] - Y[i + 1]);
                var at = T[i + 1] - T[i];

                if (!( at >= ax + ay && (at - ax - ay) % 2 == 0) ) 
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }

        static long Abs(long a) {
            return (a < 0) ? -a : a;
        }
    }
}
