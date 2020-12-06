using System;
using System.Linq;

namespace arc109a
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var a = inputs[0];
            var b = inputs[1];
            var x = inputs[2];
            var y = inputs[3];

            if (a > b)
            {
                if (a == b || a-1 == b)
                {
                    Console.WriteLine(x);
                    return;
                }

                var res1 = x + y * (a - b - 1);
                res1 = Math.Min(((a - b) * 2 - 1) * x, res1);
                res1 = Math.Min(((a - b) * 2 - 1) * x - 2*x + y, res1);
                Console.WriteLine(res1);
            }
            else {
                if (a == b)
                {
                    Console.WriteLine(x);
                    return;
                }

                var res1 = x + y * (b - a);
                res1 = Math.Min(((b - a) * 2 + 1) * x, res1);
                Console.WriteLine(res1);
            }
        }
    }
}
