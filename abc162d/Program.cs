using System;

namespace abc162d
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            char[] S = Console.ReadLine().ToCharArray();
            
            long res = 0;
            for (int i = 0; i < N; ++i) 
            {
                for (int j = i+1; j < N; ++j)
                {
                    if (S[i] == S[j]) continue;
                    for (int k = j + 1; k < N; ++k)
                    {
                        if (j - i == k - j) continue;
                        // Console.WriteLine(string.Format("({0},{1},{2})", i, j, k));
                        if (S[i] == S[k]) continue;
                        if (S[j] == S[k]) continue;
                        res++;
                    }
                }
            }
            Console.WriteLine(res);
        }
    }
}
