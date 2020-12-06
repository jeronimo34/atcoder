using System;
using System.Linq;

namespace aoj0516
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                var n = inputs[0];
                var k = inputs[1];
                if (n == 0 && k == 0) break;

                int[] a = new int[n];

                for (int i = 0; i < n; ++i)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }

                

                int[] s = new int[n + 1];
                s[0] = 0;
                for (int i = 0; i < n; ++i) s[i + 1] = s[i] + a[i];

                var res = -1000000000;
                for (int i = 0; i + k <= n; ++i)
                {
                    res = Math.Max(s[i + k] - s[i], res);
                }

                Console.WriteLine(res);
            }
            
        }
    }
}
