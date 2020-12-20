using System;
using System.Linq;

namespace abc143c
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            char[] S = Console.ReadLine().ToCharArray();

            int res = 0;
            for (int i = 0; i < N; ++i) {
                res++;
                var tmp = S[i];
                while (i + 1 < N && tmp == S[i + 1]) i++;
            }

            Console.WriteLine(res);
        }
    }
}
