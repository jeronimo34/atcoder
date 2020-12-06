using System;
using System.Linq;

namespace abc182a
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            var A = inputs[0];
            var B = inputs[1];

            Console.WriteLine(Math.Max(2*A + 100 - B, 0));
        }
    }
}
