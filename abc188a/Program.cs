using System;
using System.Linq;

namespace abc188a
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            var X = inputs[0];
            var Y = inputs[1];

            var mn = Math.Min(X, Y);
            var mx = Math.Max(X, Y);

            if (mn + 3 > mx)
            {
                Console.WriteLine("Yes");
            }
            else {
                Console.WriteLine("No");
            }
        }
    }
}
