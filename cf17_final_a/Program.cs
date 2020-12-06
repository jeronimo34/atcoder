using System;

namespace cf17_final_a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            if (s.Length <= 9) {
                for (var i = 0; i < s.Length-1; ++i) {
                    if (s[i] == s[i+1] && s[i] == 'A') {
                        Console.WriteLine("NO");
                        return;
                    }

                    if (s[i] == 'K' && s[i + 1] == 'A')
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                    if (s[i] == 'I' && s[i + 1] == 'A')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }

                if (s.Replace("A", "") == "KIHBR") {
                    Console.WriteLine("YES");
                    return;
                }
            }

            Console.WriteLine("NO");
        }
    }
}
