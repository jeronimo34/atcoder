using System;
using System.Collections.Generic;
using System.Linq;

namespace abc155c
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Dictionary<string, int> dict = new Dictionary<string, int>();
            int mx = 0;
            for (var i = 0; i < N; ++i)
            {
                var s = Console.ReadLine();

                if (dict.ContainsKey(s)) dict[s]++;
                else dict[s] = 1;
                mx = Math.Max(dict[s], mx);
            }


            foreach (var val in dict.OrderBy(x => x.Key).OrderBy(x => x.Value)) {
                if(mx == val.Value) Console.WriteLine(val.Key);
            }
        }
    }
}
