using System;
using System.Linq;

namespace abc163c
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            int[] res = new int[N];

            for (int i = 0; i < N - 1; ++i) {
                res[a[i] - 1]++;
            }

            for (int i = 0; i < N; ++i) {
                Console.WriteLine(res[i]);
            }
        }
    }
}
