using System;
using System.Collections.Generic;
using System.Linq;

namespace abc164c
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, bool>();
            for (var i = 0; i < N; ++i)
            {
                var s = Console.ReadLine();
                if (!dict.ContainsKey(s)) dict.Add(s, true);
            }

            Console.WriteLine(dict.Count);
        }
    }
}
