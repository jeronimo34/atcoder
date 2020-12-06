using System;
using System.Linq;

namespace abc184a
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var a = inputs[0];
            var b = inputs[1];
            inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var c = inputs[0];
            var d = inputs[1];

            Console.WriteLine(a*d-b*c);

        }
    }
}
