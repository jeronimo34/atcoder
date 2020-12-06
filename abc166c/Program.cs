using System;
using System.Linq;

namespace abc166c
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var N = inputs[0];
            var M = inputs[1];

            long[] H = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

            bool[] res = new bool[N];
            Array.Fill(res, true);

            for (var i = 0; i < M; ++i)
            {
                inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)-1).ToArray();
                var a = inputs[0];
                var b = inputs[1];

                if (H[a] < H[b])
                {
                    res[a] = false;
                }
                else if (H[a] > H[b])
                {
                    res[b] = false;
                }
                else 
                {
                    res[a] = res[b] = false;
                }
            }

            Console.WriteLine(res.Where(x => x).Count());
        }
    }
}
