using System;
using System.Collections.Generic;
using System.Linq;

namespace atc001b
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var N = inputs[0];
            var Q = inputs[1];
            UnionFind uf = new UnionFind(N);

            for (int i = 0; i < Q; ++i) {
                inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                var (p, a, b) = (inputs[0], inputs[1], inputs[2]);

                if (p == 0)
                {
                    //連結
                    uf.Unite(a, b);
                }
                else 
                {
                    //判定
                    if (uf.Same(a, b))
                    {
                        Console.WriteLine("Yes");
                    }
                    else {
                        Console.WriteLine("No");
                    }
                }
            }

        }

        class UnionFind {
            int[] parents;
            int[] ranks;

            public UnionFind(int n) 
            {
                parents = new int[n];
                ranks = new int[n];
                for (int i = 0; i < n; ++i) {
                    parents[i] = i;
                    ranks[i] = 0;
                }
            }

            private int Root(int x) {
                return parents[x] == x ? x : parents[x] = Root(parents[x]);//経路圧縮
            }

            /// <summary>
            /// 同じグループに属するか否か
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <returns></returns>
            public bool Same(int x, int y) {
                return Root(x) == Root(y);
            }

            /// <summary>
            /// 併合
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            public void Unite(int x, int y) {
                x = Root(x);
                y = Root(y);
                if (x == y) return;

                if (ranks[x] < ranks[y])
                {
                    parents[x] = y;
                }
                else {
                    parents[y] = x;
                    if (ranks[x] == ranks[y]) ranks[x]++;
                }
            }
        }
    }
}
