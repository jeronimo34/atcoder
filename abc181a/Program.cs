using System;

namespace abc181a
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            if (N % 2 == 1)
            {
                Console.WriteLine("Black");
            }
            else {
                Console.WriteLine("White");
            }
        }
    }
}
