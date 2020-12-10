using System;
using System.Linq;

namespace abc127c
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var N = inputs[0];
            var M = inputs[1];

            int mxL = 0;
            int mnR = 100001; 
            for (var i = 0; i < M; ++i)
            {
                inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                var L = inputs[0];
                var R = inputs[1];

                mxL = Math.Max(mxL, L);
                mnR = Math.Min(mnR, R);
            }

            Console.WriteLine(Math.Max(0, mnR - mxL+1));
        }
    }
}
