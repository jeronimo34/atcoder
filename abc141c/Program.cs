using System;
using System.Linq;

namespace abc141c
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] inputs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            var (N, K, Q) = (inputs[0], inputs[1], inputs[2]);

            var score = new int[N];
            for (int i = 0; i < Q; ++i) {
                int a = int.Parse(Console.ReadLine())-1;
                score[a]++;
            }

            for (int i = 0; i < N; ++i) 
            {
                if (K - (Q - score[i]) > 0)
                {
                    Console.WriteLine("Yes");
                }
                else 
                {
                    Console.WriteLine("No");
                }
            }

        }
    }
}
