using System;
using System.Linq;

namespace arc109c
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var n = inputs[0];
            var K = inputs[1];
            var s = Console.ReadLine();

            s += s;
            
            for (var k = 0; k < K; ++k) 
            {
                var next = "";
                for (int i = 0; i < s.Length - 1; i += 2)
                {
                    if ((s[i] == 'R' && s[i + 1] == 'S') || (s[i] == 'S' && s[i + 1] == 'R'))
                    {
                        next += 'R';
                    }
                    else if ((s[i] == 'P' && s[i + 1] == 'R') || (s[i] == 'R' && s[i + 1] == 'P'))
                    {
                        next += 'P';
                    }
                    else if ((s[i] == 'S' && s[i + 1] == 'P') || (s[i] == 'P' && s[i + 1] == 'S'))
                    {
                        next += 'S';
                    }
                    else
                    {
                        next += s[i];
                    }
                }
                s = next+next;
                if (s.Length == 1) break;
            }

            Console.WriteLine(s[0]);
        }
    }
}
