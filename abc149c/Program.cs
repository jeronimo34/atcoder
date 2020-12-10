using System;

namespace abc149c
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());

            bool[] isPrime = new bool[200000];
            Array.Fill(isPrime, true);
            isPrime[0] = isPrime[1] = false;
            for (int i = 2; i < 200000; ++i) 
            {
                if (!isPrime[i]) continue;
                for (int j = i*2; j < 200000; j += i) isPrime[j] = false;
            }

            for (int i = X; i < 200000; ++i) {
                if (isPrime[i]) {
                    Console.WriteLine(i);
                    return;
                }
            }
        }
    }
}
