using System;
using System.Linq;

namespace abc185a
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var (A, B, C, D) = (inputs[0], inputs[1], inputs[2], inputs[3]);
            Console.WriteLine(Math.Min(A, Math.Min(B, Math.Min(C, D))));
        }
    }
}
