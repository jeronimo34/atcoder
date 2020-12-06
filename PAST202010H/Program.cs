using System;
using System.Linq;

namespace PAST202010H
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int N=inputs[0];
            int M=inputs[1];
            int K = inputs[2];

            int n = Math.Min(N, M);//1辺の長さ
            int[,] graph = new int[N, M];

            for (int i = 0; i < N; ++i) {
                var s = Console.ReadLine().ToCharArray();
                for (int j = 0; j < M; ++j) {
                    graph[i,j] = int.Parse("" + s[j]);
                }
            }

            while (n > 0) 
            {
                var w = n;
                var h = n;

                for (int i = 0; i+h <= N; ++i) {
                    for (int j = 0; j+w <= M; ++j) {
                        var modecount = GetModeValueCount(j, i, w, h, graph); //最頻値のマスの数取得
                        var other = w*h -modecount;//最頻値以外のマスの数

                        if (other <= K) {
                            Console.WriteLine(n);
                            return;
                        }                        
                    }
                }
                n--;
            }

        }

        /// <summary>
        /// 最頻値のマスの数
        /// </summary>
        /// <param name="sx"></param>
        /// <param name="sy"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <param name="graph"></param>
        /// <returns></returns>
        static int GetModeValueCount(int sx, int sy, int w, int h, int[,] graph) {

            int[] mode = new int[10];
            Array.Fill(mode, 0);

            for (int y = sy; y < sy+h; ++y) {
                for (int x = sx; x < sx+w; ++x) {
                    mode[graph[y, x]]++;    
                }
            }

            var maxval = -1;
            var modeval = -1;

            for (int i = 0; i < 10; ++i) {

                if (maxval < mode[i]) {
                    maxval = mode[i];
                    modeval = i;
                }
            }

            var modeValueCount = 0;
            for (int y = sy; y < sy + h; ++y)
            {
                for (int x = sx; x < sx + w; ++x)
                {
                    if (modeval == graph[y, x]) modeValueCount++;
                }
            }

            return modeValueCount;
        }
    }
}
