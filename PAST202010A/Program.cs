using System;
using System.Linq;

namespace PAST202010A
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            var A = inputs[0];
            var B = inputs[1];
            var C = inputs[2];

            if ((B < A && A < C) ||
                (C < A && A < B))
            {
                Console.WriteLine("A");
                return;
            }

            if ((A < B && B < C) ||
                (C < B && B < A))
            {
                Console.WriteLine("B");
                return;
            }

            if ((A < C && C < B) ||
                (B < C && C < A)) 
            {
                Console.WriteLine("C");
                return;
            }
        }
    }
}
