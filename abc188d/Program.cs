using System;
using System.Collections.Generic;
using System.Linq;

namespace abc188d
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            var N = inputs[0];
            var C = inputs[1];

            Dictionary<long, long> dict = new Dictionary<long, long>();

            for (int i = 0; i < N; ++i) {
                var inputs2 = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
                var (a, b, c) = (inputs2[0], inputs2[1], inputs2[2]);
               
                if(dict.ContainsKey(a)) dict[a] += c;
                else dict[a] = c;

                if (dict.ContainsKey(b+1)) dict[b + 1] -= c;
                else dict[b + 1] = -c;

            }

            var dict2 = dict.OrderBy(x => x.Key);

            decimal res = 0;
            decimal S = 0;
            long cursor = 0;
            foreach (var item in dict2) 
            {
                

                if (S < C)
                {
                    res += S * (item.Key - cursor);
                }
                else { 
                    res += C * (item.Key - cursor);
                }
                S += item.Value;

                // Console.WriteLine(item.Key + " " + item.Value + " " + S);
                cursor = item.Key;
            }

            Console.WriteLine(res);

        }
    }
}
