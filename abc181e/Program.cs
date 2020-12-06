using System;
using System.Linq;

namespace abc181e
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            var N = inputs[0];
            var M = inputs[1];

            var H = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            var W = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            H.Sort();
            W.Sort();

            /*
            var minSum = 9999999999999;
            var minSumIndex = 0;

            for (var i = 0; i < N-1; ++i) {
                for (var j = 0; j < M; ++j) {
                    if (H[i] <= W[j] && W[j] <= H[i + 1]) {

                        if (minSum > W[j] - H[i] + H[i + 1] - W[j]) {
                            minSum = W[j] - H[i] + H[i + 1] - W[j];
                            minSumIndex = j;
                        }
                    }

                    if (H[i + 1] < W[j]) {
                        if (minSum > H[i + 1] - W[j])
                        {
                            minSum = H[i + 1] - W[j];
                            minSumIndex = j;
                        }
                    }

                    if (W[j] < H[i]) { 
                    
                    }

                }
            }*/

            var S = new int[N / 2];
            var S2 = new int[N / 2];
            
            var sum = 0;
            for (var i = 0; i < N-1; i += 2) {
                sum += Math.Abs(H[i] - H[i + 1]);
                S[i / 2] = sum;
            }

            sum = 0;
            for (var i = 1; i < N - 1; i += 2)
            {
                sum += Math.Abs(H[i] - H[i + 1]);
                S2[i / 2] = sum;
            }

            long res = 10 << 9;

            for (var i = 0; i < M; ++i) {

                var w = W[i];

                //2分探索で挿入位置を決定
                var ng = N;
                var ok = 0;

                while (ng - ok > 1)
                {
                    var mid = (int)(ng + ok) / 2;
                    if (H[mid] < w) ok = mid;
                    else ng = mid;
                }

                res = Math.Min(res, S[(ok-1)/2] + Math.Abs(H[ok] - w) + S2[ok/2]);
            }
        
            Console.WriteLine(res);
        }
    }
}
