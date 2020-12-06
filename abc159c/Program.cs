using System;

namespace abc159c
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse( Console.ReadLine());

            var N = L / 3;
            Console.WriteLine(N * N * N);
        }
    }
}
