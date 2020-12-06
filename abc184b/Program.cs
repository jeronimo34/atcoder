using System;
using System.Linq;

namespace abc184b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int n = inputs[0];
            int x = inputs[1];
            char[] s = Console.ReadLine().ToCharArray();
            int res = x;

            for (int i = 0; i < n; ++i) {
                if (s[i] == 'o') res++;
                else res = Math.Max(res - 1, 0);
            }

            Console.WriteLine(res);
        }
    }
}
