using System;
using System.Linq;

namespace abc126c
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();
            var (N, K) = (inputs[0], inputs[1]);

            double res = 0;
            for (double a = 1; a <= N; ++a) 
            {
                var n = 0;
                while (Math.Pow(2, n) * a < K) n++;
                res += Math.Pow(0.5, n);
            }

            Console.WriteLine(res*1.0/N);
        }
    }
}
