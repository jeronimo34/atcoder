using System;
using System.Linq;

namespace abc188b
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            var B = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

            decimal res = 0;
            for (int i = 0; i < N; ++i) {
                res += A[i] * B[i];
            }

            if (res == 0)
            {
                Console.WriteLine("Yes");
            }
            else {
                Console.WriteLine("No");
            }

        }
    }
}
