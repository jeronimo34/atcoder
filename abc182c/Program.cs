using System;
using System.Linq;
using System.Numerics;

namespace abc182c
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = Console.ReadLine().ToCharArray().Select(x => int.Parse(""+x)).ToArray() ;

            //消さない場合
            if(N.Sum() % 3 == 0) {
               Console.WriteLine("0");
               return;
            }

            if (N.Count() == 1) {
                Console.WriteLine("-1");
                return;
            }

            //1つ消した場合
            for (var i = 0; i < N.Length; ++i) {
                var t = N[i];
                N[i] = 0;
                if (N.Sum() % 3 == 0) {
                    Console.WriteLine("1");
                    return;
                }
                N[i] = t;

            }

            if (N.Count() == 2)
            {
                Console.WriteLine("-1");
                return;
            }

            //2つ消した場合 11111
            for (var i = 0; i < N.Length; ++i)
            {
                for (var j = i; j < N.Length; ++j)
                {
                    if (i == j) continue;

                    var t = N[i];
                    N[i] = 0;

                    var t2 = N[j];
                    N[j] = 0;

                    if (N.Sum() % 3 == 0)
                    {
                        Console.WriteLine("2");
                        return;
                    }

                    N[i] = t;
                    N[j] = t2;
                }

            }

            Console.WriteLine("-1");

        }


    }
}
