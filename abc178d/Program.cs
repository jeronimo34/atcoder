using System;

namespace abc178d
{
    class Program
    {
        static int S;
        static long res = 0;
        static long[] memo;

        static void Main(string[] args)
        {
            S = int.Parse(Console.ReadLine());
            memo = new long[S+1];
            for (int i = 0; i <= S; ++i) memo[i] = -1;
            memo[S] = 1;

            for (int i = S; i >= 3; --i)
            {
                res += Dfs(i);
                res %= 1000000007;
            }

            Console.WriteLine(res);
        }

        static long Dfs(int num)
        {
            if (memo[num] != -1) return memo[num];

            for (int i = 3; i <= S - num; ++i)
            {
                if(memo[num] == -1) memo[num] = Dfs(num + i);
                else memo[num] = (memo[num]+Dfs(num + i)) % 1000000007;
            }

            return memo[num] != -1 ? memo[num] : (memo[num] = 0);
        }
    }
}
