using System;
using System.Linq;

namespace arc084a
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = long.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToList();
            var B = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToList();
            var C = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToList();

            A.Sort();
            B.Sort();
            C.Sort();

            //var resB = new long[N];
            long res = 0;

            for (var i = 0; i < B.Count; ++i)
            {
                var ok = -1;
                var ng = B.Count;
                while (ng - ok > 1)
                {
                    var mid = (ok + ng) / 2;
                    if (A[mid] < B[i]) ok = mid;
                    else ng = mid;
                }
                var resAB = ok + 1;

                ng = -1;
                ok = C.Count;
                while (ok - ng > 1)
                {
                    var mid = (ok + ng) / 2;
                    if (B[i] < C[mid]) ok = mid;
                    else ng = mid;
                }

                var resBC = N-ok;

                res += resAB * resBC;
            }

            Console.WriteLine(res);
        }
    }
}