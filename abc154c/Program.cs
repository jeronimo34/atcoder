using System;
using System.Collections.Generic;
using System.Linq;

namespace abc154c
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

            var dictionaly = new Dictionary<long, bool>();

            for (int i = 0; i < N; ++i) {
                if (dictionaly.ContainsKey(A[i]))
                {
                    Console.WriteLine("NO");
                    return;
                }
                else {
                    dictionaly[A[i]] = true;
                }
            }
            Console.WriteLine("YES");

        }
    }
}
