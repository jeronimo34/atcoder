using System;
using System.Linq;

namespace abc158c
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x=>int.Parse(x)).ToArray();
            var (A, B) = (inputs[0], inputs[1]);

            for (double i = 0; i <= 10000; ++i) 
            {
                if ((int)(i * 0.08) == A && (int)(i * 0.1) == B) {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine(-1);
        }
    }
}
