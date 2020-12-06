using System;

namespace abc184d
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var A = int.Parse(input[0]);
            var B = int.Parse(input[1]);
            var C = int.Parse(input[2]);

            var res1 = 0;//man
            var res2 = 0;//oldman
            var res3 = 0;//akachan
            var success = false;
            for (var i = 0; i <= N; ++i)
            {
                var S = M - 3 * i;
                var N2 = N - i;

                res2 = i;

                if ((4 * N2 - S) % 2 != 0) continue;

                res1 = (int)((4 * N2 - S) * 0.5);
                res3 = N2 - res1;

                if (res1 >= 0 && res2 >= 0 && res3 >= 0)
                {
                    success = true;
                    break;
                }
            }

            if (success)
            {
                Console.WriteLine(string.Format("{0} {1} {2}", res1, res2, res3));
            }
            else
            {
                Console.WriteLine("-1 -1 -1");
            }
        }
    }
}
