using System;
using System.Linq;

namespace abc148c
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            var A = inputs[0];
            var B = inputs[1];
            Console.WriteLine(lcm(A,B));
        }

        static long lcm(long a, long b) => a * b / gcd(a, b);
        static long gcd(long a, long b) => (b == 0) ? a : gcd(b, a % b);
    }
}
