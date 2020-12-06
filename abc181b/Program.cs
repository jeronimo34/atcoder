using System;
using System.Linq;

namespace abc181b
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = long.Parse(Console.ReadLine());
            long res = 0;
            for (var i = 0; i < N; ++i) {
                var inputs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
                var a = inputs[0];
                var b = inputs[1];

                var tSum = (b - a+1)*(a + b) / 2;
                res += tSum;
            }

            Console.WriteLine(res);
        }
    }
}
