using System;
using System.Collections.Generic;
using System.Linq;

namespace PAST202010F
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            var N = inputs[0];
            var K = inputs[1];
            Dictionary<string, int> res = new Dictionary<string, int>();
            
            for (int i = 0; i < N; ++i) 
            {
                var s = Console.ReadLine();

                if (!res.ContainsKey(s)) res[s] = 0;
                res[s]++;
            }

            var sorted = res.OrderByDescending(x => x.Value);

            var sortedArray = sorted.ToArray();

            var res2 = sortedArray[K-1];

            var appearCount = res[res2.Key];



            if (res.Where(x => x.Value == appearCount).Count() > 1)
            {
                Console.WriteLine("AMBIGUOUS");
            }
            else 
            {
                Console.WriteLine(res2.Key);
            }

        }
    }
}
