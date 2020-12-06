using System;
using System.Collections.Generic;
using System.Linq;

namespace abc061a
{
    class Program
    {
        static void Main(string[] args)
        {
            var S = Console.ReadLine();

            int n = S.Length;
            var list = new List<int>();
            long sum = 0;
            for (int bit = 0; bit < (1 << n); ++bit) 
            {
                if ((bit & 1) > 0) continue;

                list.Clear();
                for (int i = 0; i < n; ++i) 
                {
                    if ((bit & (1 << i)) > 0) 
                    {
                        list.Add(i);
                    }
                }

                var tmpS = S;
                for (int i = 0; i < list.Count; ++i) 
                {
                    tmpS = tmpS.Insert(list[i]+i," ");
                }

                sum += tmpS.Trim().Split(' ').Select(x => long.Parse(x)).Sum();
            }

            Console.WriteLine(sum);
        }
    }
}
