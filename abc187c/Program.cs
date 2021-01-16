using System;
using System.Collections.Generic;

namespace abc187c
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var N = int.Parse(Console.ReadLine());//.ToCharArray().ToList();

            Dictionary<string, int> dict = new Dictionary<string, int>();
            Dictionary<string, int> dict2 = new Dictionary<string, int>();

            for (int i = 0; i < N; ++i)
            {
                var s = Console.ReadLine();

                bool isBikkuri = false;
                if (s[0] == '!') isBikkuri = true;

                s = s.TrimStart('!');

                if (isBikkuri) {
                    if (!dict2.ContainsKey(s))
                    {
                        dict2[s] = 1;
                    }
                }
                else {
                    if (!dict.ContainsKey(s))
                    {
                        dict[s] = 1;
                    }
                }

                if (dict.ContainsKey(s) && dict2.ContainsKey(s) && dict[s] > 0 && dict2[s] > 0) {
                    Console.WriteLine(s);
                    return;
                }
            }

            Console.WriteLine("satisfiable");
        }
    }
}
