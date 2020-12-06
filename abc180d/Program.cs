using System;
using System.Linq;

namespace abc180d
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => decimal.Parse(x)).ToArray();

            decimal X = inputs[0];
            decimal Y = inputs[1];
            decimal A = inputs[2];
            decimal B = inputs[3];
            decimal res = 0;

            while (A * X < X + B && A * X < Y)
            {
                X *= A;
                res++;
            }
            res += (Y - 1 - X) / B;

            Console.WriteLine(Math.Floor(res));
        }
    }
}
