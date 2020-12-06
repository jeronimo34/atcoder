using System;

namespace abc106c
{
    class Program
    {
        static void Main(string[] args)
        {
            var S = Console.ReadLine();
            var K = long.Parse(Console.ReadLine());

            int moreoneindex = 0;
            while (moreoneindex < S.Length && S[moreoneindex] == '1') moreoneindex++;

            if (K <= moreoneindex) 
            {
                Console.WriteLine("1");
                return;
            }

            Console.WriteLine(S[moreoneindex]);            
        }
    }
}
