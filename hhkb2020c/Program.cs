using System;
using System.Collections.Generic;
using System.Linq;

namespace hhkb2020c
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] P = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            List<int> P2 = new List<int>();

            
            for (var i = 0; i <= 200000; ++i) P2.Add(i);

            var mnIndex = 0;

            for (var i = 0; i < N; ++i) 
            {
                P2[P[i]] = 200001;
                while (P2[mnIndex] > 200000) mnIndex++;
                Console.WriteLine(P2[mnIndex]);                
            }
        }
    }
}
