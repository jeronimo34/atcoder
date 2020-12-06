using System;
using System.Linq;

namespace abc005d
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            int[,] G = new int[N, N];
            for (int i = 0; i < N; ++i)
            {
                var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                for (int j = 0; j < N; ++j)
                {
                    G[i, j] = inputs[j];
                }
            }

            int[,] S = new int[N + 1, N + 1];
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    S[i+1, j+1] = S[i+1, j] + S[i, j+1] - S[i, j] + G[i, j];
                }
            }

            // mx[v] := 面積がvの長方形領域の総和の最大値
            int[] mx = new int[N*N + 1]; 

            for (int x1 = 0; x1 < N; ++x1) {
                for (int y1 = 0; y1 < N; ++y1) {
                    for (int x2 = x1 + 1; x2 <= N; ++x2) {
                        for (int y2 = y1 + 1; y2 <= N; ++y2) {
                            int area = (x2 - x1) * (y2 - y1);
                            int sum = S[x2, y2] - S[x1, y2] - S[x2, y1] + S[x1, y1];
                            mx[area] = Math.Max(mx[area], sum);
                        }
                    }
                }
            }

            for (int i = 0; i < N*N; ++i) mx[i+1] = Math.Max(mx[i], mx[i + 1]);

            var Q = int.Parse(Console.ReadLine());
            for (int i = 0; i < Q; ++i)
            {
                int p = int.Parse(Console.ReadLine());
                Console.WriteLine(mx[p]);           
            }
        }
    }
}
