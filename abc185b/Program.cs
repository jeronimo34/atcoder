using System;
using System.Linq;

namespace abc185b
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var N = inputs[0];
            var M = inputs[1];
            var T = inputs[2];

            var battery = N;
            var basePoint = 0;

            for (var i = 0; i < M; ++i)
            {
                inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                var a = inputs[0];
                var b = inputs[1];

                battery -= a - basePoint;
                if (battery <= 0) {
                    Console.WriteLine("No");
                    return;
                }
                battery += b - a;
                battery = Math.Min(battery, N);
                basePoint = b;
            }

            battery -= T - basePoint;
            if (battery <= 0)
            {
                Console.WriteLine("No");
                return;
            }

            Console.WriteLine("Yes");
        }
    }
}
