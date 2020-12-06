using System;
using System.Linq;

namespace PAST202010B
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();

            var X = inputs[0];
            var Y = inputs[1];

            if (Y == 0) {
                Console.WriteLine("ERROR");
                return;
            }

            var res = X / Y;
            Console.WriteLine((Math.Floor(res * 100)/100).ToString("0.00"));
        }
    }
}
