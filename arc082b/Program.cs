using System;
using System.Linq;

namespace arc082b
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var P = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            var res = 0;
            for (int i = 0; i < N; ++i) {

                var i2 = i + 1;
                if (i+1 < N && i2 == P[i] && i2 + 1 == P[i + 1])
                {
                    res++;
                    i++;
                }
                else if (i2 == P[i])
                {
                    res++;
                }
            }

            Console.WriteLine(res);
        }
    }
}
