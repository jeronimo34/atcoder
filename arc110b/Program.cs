using System;

namespace arc110b
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = long.Parse(Console.ReadLine());
            var T = Console.ReadLine();

            if (N == 1)
            {
                if (T == "0")
                {
                    Console.WriteLine(10000000000);
                    return;
                }
                else if (T == "1") {
                    Console.WriteLine(20000000000);
                    return;
                }
            }

            if (T[0] == '0')
            {
                T = "11" + T;
            }
            else if (T[0] == '1' && T[1] == '0')
            {
                T = "1" + T;
            }

            if (T[T.Length - 1] == '1' && T[T.Length - 2] == '1')
            {
                T = T + "0";
            }
            else if (T[T.Length - 1] == '1')
            {
                T = T + "10";
            }

            for (int i = 0; i < T.Length; i += 3)
            {
                if (T[i] != '1' || T[i + 1] != '1' || T[i + 2] != '0')
                {
                    Console.WriteLine(0);
                    return;
                }
            }

            long res = T.Length;
            res = 10000000000 - (res / 3 - 1);

            Console.WriteLine(res);
        }
    }
}
