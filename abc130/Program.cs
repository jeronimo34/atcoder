using System;
using System.Linq;

namespace abc130c
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();
            var (W, H, x, y) = (inputs[0], inputs[1], inputs[2], inputs[3]);

            int pattern = 0;
            if (W == 2 * x && H == 2 * y) {
                pattern = 1;
            }

            Console.WriteLine("" + (double)(W * H * 0.5) + " " + pattern);
        }
    }
}
