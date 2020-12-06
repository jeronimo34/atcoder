using System;
using System.Linq;

namespace abc182b
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = long.Parse( Console.ReadLine());
            var A = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

            var mx = A.Max();

            var res = 0;
            var res2 = 0;
            for (var k = 2; k <= mx; ++k) 
            {
                var tres = 0;
                for (var i = 0; i < N; ++i) {
                    if (A[i] % k == 0)
                    {
                        tres++;
                    }
                }

                if (tres >= res) {
                    res = tres;
                    res2 = k;
                }
            }

            Console.WriteLine(res2);
        }
    }
}
