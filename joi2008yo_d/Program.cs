using System;
using System.Collections.Generic;
using System.Linq;

namespace joi2008yo_d
{
    class Program
    {
        static void Main(string[] args)
        {
            var M = long.Parse(Console.ReadLine());

            var seza = new List<Tuple<long, long>>();
            for (var i = 0; i < M; ++i)
            {
                var inputs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
                var x = inputs[0];
                var y = inputs[1];
                seza.Add(new Tuple<long, long>(x, y));
            }

            var N = long.Parse(Console.ReadLine());

            var hosi = new List<Tuple<long, long>>();

            for (var i = 0; i < N; ++i)
            {
                var inputs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
                var x = inputs[0];
                var y = inputs[1];
                hosi.Add(new Tuple<long, long>(x, y));
            }

            for (var i = 0; i < N; ++i)
            {
                var ho = hosi[i];
                var dx = hosi[i].Item1 - seza[0].Item1;
                var dy = hosi[i].Item2 - seza[0].Item2;

                var found = true;
                for (var j = 0; j < seza.Count; ++j)
                {
                    var sez = seza[j];
                    var nx = seza[j].Item1 + dx;
                    var ny = seza[j].Item2 + dy;

                    if (nx < 0 || 1000000 < nx ||
                        ny < 0 || 1000000 < ny)
                    {
                        found = false;
                        break;
                    }

                    if (hosi.Where(x => x.Item1 == nx && x.Item2 == ny).Count() == 0) {
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    Console.WriteLine(string.Format("{0} {1}", dx, dy));
                    return;
                }
            }
        }
    }
}
