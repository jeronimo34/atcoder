using System;
using System.Linq;

namespace arc085b
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var N = inputs[0];
            var Z = inputs[1];//Xの初期手札
            var W = inputs[2];//Yの初期手札
            var A = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();


            if (2 <= N)
            {
                Console.WriteLine(Max(Abs(W - A[N - 1]), Abs(A[N - 1] - A[N - 2])));
            }
            else {
                Console.WriteLine(Abs(W - A[N - 1]));
            }
        }

        static int Abs(int a) { 
        return a < 0 ? -a : a;
        }

        static int Max(int a, int b) {
            return a > b ? a : b;
        }
    }
}
