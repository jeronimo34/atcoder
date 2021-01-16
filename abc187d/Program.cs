using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace abc187d
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            BigInteger aoki = 0;
            BigInteger takahasi = 0;

            var hito = new List<Tuple<BigInteger, BigInteger>>();
            for (int i = 0; i < N; ++i) {
                var inputs = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();
                var (a, b) = (inputs[0], inputs[1]);

                hito.Add(new Tuple<BigInteger, BigInteger>(a, b));
                aoki += a;
            }
            // hito.Sort((b, a) => Math.Sign(a.Item1 + a.Item2 - (b.Item1 + b.Item2)));

            hito = hito.OrderByDescending(x => x.Item1).OrderByDescending(x => x.Item1 + x.Item2).ToList();

            /*Sort((b, a) =>
        (Math.Sign(a.Item1+a.Item2 - (b.Item1 + b.Item2)) != 0) ? 
        Math.Sign(a.Item1 + a.Item2 - (b.Item1 + b.Item2)) :
        ( a.Item1 > b.Item1 ? 1 : -1 ) );*/

            BigInteger res = 0;
            for (int i = 0; i < hito.Count; ++i) {
                var h = hito[i];

                aoki -= h.Item1;
                takahasi += h.Item1 + h.Item2;

                res++;
                if (aoki < takahasi) {
                    break;
                }
            }

            Console.WriteLine(res);
        }
    }
}
