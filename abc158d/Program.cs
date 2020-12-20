using System;
using System.Collections.Generic;
using System.Linq;

namespace abc158d
{
    class Program
    {
        static void Main(string[] args)
        {
            var S = Console.ReadLine().ToCharArray().ToList();
            int Q = int.Parse(Console.ReadLine());

            
            bool flip = false;
            for (int i = 0; i < Q; ++i) 
            {
                var inputs = Console.ReadLine().Split(' ');
                var t = int.Parse(inputs[0]);

                if (t == 1)
                {
                    flip = !flip;
                }
                else 
                {
                    var f = int.Parse(inputs[1]);
                    var c = inputs[2];

                    if (flip) f = -f + 3;
                    if (f == 1)
                    {
                        S.Insert(0, c[0]);
                    }
                    else {
                        S.Insert(S.Count, c[0]);
                    }
                }
            }

            char[] res = new char[S.Count];
            if (flip)
            {
                for (int i = 0; i < S.Count; ++i) res[i] = S[S.Count-1-i];
            }
            else
            {
                for (int i = 0; i < S.Count; ++i) res[i] = S[i];
            }

            Console.WriteLine(new string(res).TrimEnd());

        }
    }
}
