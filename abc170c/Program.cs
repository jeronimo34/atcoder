using System;
using System.Linq;

namespace abc170c
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            int X = inputs[0];
            int N = inputs[1];

            int[] P = null;

            if (N > 0)
            {
                P = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            }
            else {
                Console.WriteLine(X);
                return;
            }

            int mn = 200;
            int res = X;

            for (var x = -200; x <= 200; ++x) 
            {
                if (P != null && P.Contains(x)) continue;

                if (Math.Abs(X - x) < mn) {
                    mn = Math.Abs(X - x);
                    res = x;
                }
            }

            Console.WriteLine(res);
        }
    }
}
