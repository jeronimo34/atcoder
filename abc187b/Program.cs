using System;
using System.Collections.Generic;

namespace abc187b
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());//.ToCharArray().ToList();

            var points = new List<Tuple<float, float>>();
            for (int i = 0; i < N; ++i)
            {
                var inputs = Console.ReadLine().Split(' ');
                var (x, y) = (float.Parse(inputs[0]), float.Parse(inputs[1]));
                points.Add(new Tuple<float, float>(x, y));
            }

            int res = 0;

            for (int i = 0; i < N; ++i) {
                for (int j = i+1; j < N; ++j) {
                    var p1 = points[i];
                    var p2 = points[j];

                    var katamuki = (p2.Item2 - p1.Item2) / (p2.Item1 - p1.Item1);

                    if (-1 <= katamuki && katamuki <= 1) res++;
                }
            }

            Console.WriteLine(res);


        }
    }
}
