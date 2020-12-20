using System;
using System.Linq;

namespace abc060c
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] inputs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            var (N, T) = (inputs[0], inputs[1]);
            long[] t = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

            long res = T;
            for (int i = 1; i < N; ++i) 
            {
                res += Math.Min(t[i] - t[i - 1], T);
            }

            Console.WriteLine(res);
        }
    }
}
