using System;
using System.Linq;

namespace arc096a
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

            var A = inputs[0];
            var B = inputs[1];
            var C = inputs[2];
            var X = inputs[3];
            var Y = inputs[4];

            //Aピザ、Bピザをそのまま買った場合
            long res = A * X + B * Y;
            long res2 = 0;

            if (X > Y)
            {
                res2 = Min(2 * X * C/*ABピザのみ*/ , 2 * Y * C + A * (X - Y)/*ABピザ＋Aピザ*/);
            }
            else 
            {
                res2 = Min(2 * Y * C/*ABピザのみ*/, 2 * X * C + B * (Y - X)/*ABピザ＋Bピザ*/);
            }

            //一番小さい値が答え
            Console.WriteLine(Min(res, res2));            
        }

        static long Min(long a, long b)
        {
            return a > b ? b : a;
        }
    }
}
