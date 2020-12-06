using System;

namespace ARC106
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            for (int a = 1; a <= 37; ++a) {
                for (int b = 1; b <= 25; ++b) {
                    var x = Pow(3, a);
                    var y = Pow(5, b);
                    if (x + y == N) {
                        Console.WriteLine(String.Format("{0} {1}",a,b));
                        return;
                    }
                }
            }
            Console.WriteLine("-1");
        }

        static long Pow(long x, long y) {
            if (y == 0) return 1;
            long res = 1;
            for (long i = 0; i < y; ++i) res *= x;
            return res;
        }
    }
}