using System;
using System.Numerics;

namespace abc171c
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());

            var alpha = new char[] { 
                'a', 'b', 'c', 'd', 'e',
                'f', 'g', 'h', 'i', 'j',
                'k', 'l', 'm', 'n', 'o',
                'p', 'q', 'r', 's', 't',
                'u', 'v', 'w', 'x', 'y', 'z'};

            var res = "";

            while (N > 0) 
            {
                N--;
                char ch = alpha[(int)(N % 26)];
                res = ch+res;
                N /= 26;
            }

            Console.WriteLine(res);
        }
    }
}
