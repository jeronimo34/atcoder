using System;
using System.Linq;

namespace abc103c
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToList();
            Console.WriteLine(A.Sum() - N);
        }
    }
}
