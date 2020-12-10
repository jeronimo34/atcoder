using System;
using System.Linq;

namespace abc153c
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var N = inputs[0];
            var K = inputs[1];

            var H = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).OrderByDescending(x => x).ToList();

            
            for (int i = 0; i < K && i < N; ++i) {
                H[i] = 0;
            }

            ulong res = 0;
            for (int i = 0; i < N; ++i)
            {
                res += (ulong)H[i];
            }

            Console.WriteLine(res);
        }
    }
}
