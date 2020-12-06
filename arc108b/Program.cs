using System;
using System.Collections.Generic;

namespace arc108b
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = long.Parse(Console.ReadLine());
            var s = Console.ReadLine().ToCharArray();

            var t = new char[N];
            long tLen = 0;

            for (long i = 0; i < N; ++i) {
                tLen++;
                t[tLen-1] = s[i];
                if (tLen >= 3 && t[tLen - 1] == 'x' && t[tLen - 2] == 'o' && t[tLen - 3] == 'f') tLen -= 3;
            }

            Console.WriteLine(tLen);

        }
    }
}
