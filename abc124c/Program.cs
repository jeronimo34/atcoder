using System;
using System.Linq;

namespace abc124c
{
    class Program
    {
        static void Main(string[] args)
        {
            var S = Console.ReadLine().ToCharArray();
            
            var wb = 0;
            var bw = 0;

            for (int i = 0; i < S.Length; ++i)
            {
                if (i % 2 == 0)
                {
                    if (S[i] == '1')
                    {
                        bw++;
                    }
                    else wb++;
                }
                else 
                {
                    if (S[i] == '0')
                    {
                        bw++;
                    }
                    else wb++;
                }
            }

            int res = Math.Min(S.Length - bw, S.Length - wb);
            Console.WriteLine(res);
        }
    }
}
