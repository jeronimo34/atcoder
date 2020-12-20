using System;
using System.Numerics;

namespace abc166d
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger X = BigInteger.Parse(Console.ReadLine());

            for (BigInteger a = -1000; a <= 1000; ++a) {
                for (BigInteger b = -1000; b <= 1000; ++b)
                {
                    if (a*a*a*a*a - b*b*b*b*b == X) 
                    {
                        Console.WriteLine(a + " " + b);
                        return;
                    }
                }
            }
        }
    }
}
