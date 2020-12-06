using System;
using System.Linq;

namespace abc116c
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var H = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            int[] A = new int[101];
            int res = 0;

            for (int i = 0; i < 100; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    if (H[j] == 0) continue;
                    H[j]--;
                    while (j + 1 < N && H[j + 1] > 0)
                    {
                        j++;
                        H[j]--;
                    }
                    res++;
                }

                if (H.All(x => x <= 0)) break;
            }

            Console.WriteLine(res);
        }
    }
}
