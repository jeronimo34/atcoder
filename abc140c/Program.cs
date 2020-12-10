using System;
using System.Linq;

namespace abc140c
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var B = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int[] A = new int[N];

            A[0] = 100000;
            for (int i = 0; i < N-1; ++i) {
                if(A[i] > B[i]) A[i] = B[i];
                A[i + 1] = B[i];
            }

            Console.WriteLine(A.Sum());
        }
    }
}
