using System;
using System.Collections.Generic;
using System.Linq;

namespace abc147c
{
    class Human {
        public List<Tuple<int, bool>> syogen = new List<Tuple<int, bool>>();
    }
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<bool[]> HonestSets = new List<bool[]> ();

            for (int bit = 0; bit < (1 << N); ++bit)
            {
                bool[] S = new bool[N];
                for (int i = 0; i < N; ++i)
                {
                    if ((bit & (1 << i)) > 0)
                    { 
                        // 列挙に i が含まれるか
                        S[i] = true;
                    }
                }
                HonestSets.Add(S);
            }

            var Humans = new Human[N];
            for (int i = 0; i < N; ++i) { 
                var A = int.Parse(Console.ReadLine());

                var human = new Human();
                for (int j = 0; j < A; ++j) {
                    var x = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                    human.syogen.Add(new Tuple<int, bool>(x[0]-1, x[1] > 0));                    
                }
                Humans[i] = human;
            }

            int res = 0;
            for (int i = 0; i < HonestSets.Count; ++i) 
            {
                var honestOrUnkind = HonestSets[i];
                bool contradictionOccured = false;

                for (int j = 0; j < N; ++j)
                {
                    //honest or layer
                    bool isHonest = honestOrUnkind[j];
                    var human = Humans[j];

                    if (isHonest)
                    {
                        foreach (var syogen in human.syogen)
                        {
                            if (honestOrUnkind[syogen.Item1] != syogen.Item2)
                            {
                                // 矛盾発生
                                contradictionOccured = true;
                                break;
                            }
                        }
                    }
                    /*
                     *不誠実な人＝必ず嘘をつく人ではない
                    else {
                        foreach (var syogen in human.syogen)
                        {
                            if (honestOrUnkind[syogen.Item1] == syogen.Item2)
                            {
                                // 矛盾発生
                                contradictionOccured = true;
                                break;
                            }
                        }
                    }*/
                    if (contradictionOccured) break;
                }

                if (!contradictionOccured) {
                    res = Math.Max(res, honestOrUnkind.Where(x => x == true).Count());
                }
            }

            Console.WriteLine(res);
        }
    }
}
