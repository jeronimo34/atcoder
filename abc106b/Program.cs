using System;

namespace abc106b
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            var res = 0;
            for (int i = 1; i <= N; i+=2) 
            {
                var cnt = 0;
                for (int j = 1; j <= i; ++j) {
                    if (i % j == 0) cnt++;
                }

                if (cnt == 8) res++;
            }

            Console.WriteLine(res);
        }


    }
}
