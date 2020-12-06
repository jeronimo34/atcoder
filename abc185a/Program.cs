using System;
using System.Linq;

namespace abc185a
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var (A, B) = (inputs[0], inputs[1]);
            double L = double.Parse(Console.ReadLine());

            int res = 0;


            Console.WriteLine(res);
        }
    }
}
