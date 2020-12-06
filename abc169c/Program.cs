using System;
using System.Linq;

namespace abc169c
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] inputs = Console.ReadLine().Split(' ').Select(x => decimal.Parse(x)).ToArray();

            decimal A = inputs[0];
            decimal B = inputs[1];

            Console.WriteLine(Math.Floor(A * B));
        }
    }
}
