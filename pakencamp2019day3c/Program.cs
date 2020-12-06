using System;
using System.Linq;

namespace pakencamp2019day3c
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var N = inputs[0];
            var M = inputs[1];

            var pointsMap = new long[N, M];

            for (var i = 0; i < N; ++i) {
                var points = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

                for (var j = 0; j < M; ++j) {
                    pointsMap[i, j] = points[j];
                }
            }

            long res = 0;
            for (var i = 0; i < M; ++i) {
                for (var j = i+1; j < M; ++j) {

                    long tsum = 0;
                    for (var k = 0; k < N; ++k) {
                        tsum += Max(pointsMap[k,i], pointsMap[k,j]);
                    }

                    res = Max(res, tsum);
                }
            }

            Console.WriteLine(res);
        }

        static long Max(long a, long b) {
            return a > b ? a : b;
        }
    }
}
