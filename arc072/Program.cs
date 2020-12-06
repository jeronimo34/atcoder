using System;
using System.Linq;
using System.Numerics;

namespace arc072
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();
            var X = inputs[0];
            var Y = inputs[1];

            if (Abs(X - Y) <= 1)
            {
                Console.WriteLine("Brown");
            }
            else {
                Console.WriteLine("Alice");
            }


        }

        static BigInteger Abs(BigInteger a) {
            return a < 0 ? -a : a;
        }
    }
}
