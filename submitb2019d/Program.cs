using System;
using System.Collections.Generic;

namespace submitb2019d
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = long.Parse(Console.ReadLine());
            var S = Console.ReadLine().ToCharArray();

            long res = 0;
            var passwd = new char[3];

            for (var i = 0; i < 1000; ++i) {
                passwd[0] = Char.Parse((i / 100).ToString());
                passwd[1] = Char.Parse(((i / 10) % 10).ToString());
                passwd[2] = Char.Parse((i % 10).ToString());

                var charIdx = 0;
                for (var j = 0; j < N; ++j) 
                {
                    if (S[j] == passwd[charIdx]) charIdx++;
                    if (charIdx == 3)
                    {
                        res++;
                        break;
                    }
                }
            }

            Console.WriteLine(res);
        }
    }
}
