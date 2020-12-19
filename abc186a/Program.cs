using System;
using System.Linq;

namespace abc186a
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            var N = inputs[0];
            var W = inputs[1];

            Console.WriteLine(N / W);
        }
    }
}
