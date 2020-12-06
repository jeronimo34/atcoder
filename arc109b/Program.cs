using System;

namespace arc109b
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long res = 0;
            n = n + 1;
            for (long i = 1; i <= 1000000000; ++i) 
            {
                if (2 * n - i * i - i < 0) {
                    break;
                }
                res++;
            }
            Console.WriteLine(n-res);
        }
    }
}
