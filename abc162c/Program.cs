using System;

namespace abc162c
{
    class Program
    {
        static void Main(string[] args)
        {
            var K = int.Parse(Console.ReadLine());

            int res = 0;
            for (int a = 1; a <= K; ++a) 
            {
                for (int b = 1; b <= K; ++b)
                {
                    for (int c = 1; c <= K; ++c)
                    {
                        res += gcd(a, gcd(b, c));
                    }
                }
            }

            Console.WriteLine(res);
        }

        static int gcd(int a, int b) => (b == 0) ? a : gcd(b, a % b);
    }
}
