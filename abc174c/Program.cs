using System;
using System.Numerics;

namespace abc174c
{
    class Program
    {
        static void Main(string[] args)
        {
            long k = long.Parse(Console.ReadLine());
            long l = k % 7 == 0 ? 9 * k / 7 : 9 * k;

            long a = 1;
            long mod = 10;

            for (long i = 1; i <= 9000000; ++i) {
                
                if (mod%l == 1) {
                    Console.WriteLine(i);
                    return;
                }

                mod = (mod % l) * 10 % l;
            }

            Console.WriteLine(-1);
        }
    }
}
