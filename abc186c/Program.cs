using System;

namespace abc186c
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = long.Parse(Console.ReadLine());

            long res = N;
            for (int i = 1; i <= N; ++i) {
                if (i.ToString().Contains('7')) 
                {
                    res--;
                    continue;
                }

                int n = i;
                while (n != 0) 
                {
                    if (n % 8 == 7) {
                        res--;
                        break;
                    }
                    n /= 8;
                }
            }

            Console.WriteLine(res);
        }
    }
}
