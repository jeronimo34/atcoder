using System;

namespace agc003a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToCharArray();

            var N = false;
            var S = false;
            var E = false;
            var W = false;

            for (var i = 0; i < s.Length; ++i) {
                if (s[i] == 'N') N = true;
                if (s[i] == 'S') S = true;
                if (s[i] == 'E') E = true;
                if (s[i] == 'W') W = true;

                if (N && S && E && W) {
                    Console.WriteLine("Yes");
                    return;
                }
            }

            if (N && S && !E && !W) 
            {
                Console.WriteLine("Yes");
                return;
            }

            if (!N && !S && E && W)
            {
                Console.WriteLine("Yes");
                return;
            }

            Console.WriteLine("No");

        }
    }
}
