using System;
using System.Linq;

namespace ABC040
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            var dp = new int[N];//i本目のコストの合計の最小値

            dp[0] = 0;
            dp[1] = Math.Abs(A[1] - A[0]);

            for (var i = 2; i < N; ++i) 
            {
                dp[i] = Math.Min(dp[i-1]+Math.Abs(A[i]-A[i-1]), dp[i-2]+Math.Abs(A[i] - A[i-2]));
            }

            Console.WriteLine(dp[N-1]);
            
        }
    }
}
