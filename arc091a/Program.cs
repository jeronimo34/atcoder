using System;
using System.Linq;

namespace arc091a
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] inputs = Console.ReadLine().Split(' ').Select(x => decimal.Parse(x)).ToArray();
            decimal N = inputs[0];
            decimal M = inputs[1];

            if (N > M) {
                (N, M) = (M, N);
            }

            if (N == 1 && M == 1) {
                Console.WriteLine(1);
                return;
            }

            if (N == 1) {
                Console.WriteLine(M - 2);
                return;
            }

            Console.WriteLine((N-2)*(M-2));
        }
    }
}
