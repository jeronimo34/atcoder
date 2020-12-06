using System;
using System.Collections.Generic;

namespace joi2009ho_b
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = long.Parse(Console.ReadLine());//環状線の全長
            var n = int.Parse(Console.ReadLine());//店舗の個数
            var m = long.Parse(Console.ReadLine());//注文の個数を表す正整数

            var shops = new List<long>();
            shops.Add(0);
            shops.Add(d);

            for (var i = 0; i < n-1; ++i) 
            { 
                var td = long.Parse(Console.ReadLine());//本店以外の店舗の位置
                shops.Add(td);
            }
            

            long res = 0;

            shops.Sort();
            for (var i = 0; i < m; ++i)
            {
                var k = long.Parse(Console.ReadLine());//宅配先の場所を表す

                //2分探索
                var ng = shops.Count-1;
                var ok = 0;

                while (ng - ok > 1) {
                    var mid = (int)(ng + ok) / 2;
                    if (shops[mid] < k) ok = mid;
                    else ng = mid;
                }

                var res1 = k - shops[ok];
                var res2 = ok+1 < shops.Count ? shops[ok+1] - k : res1;
                res += Math.Min(res1, res2);
            }

            Console.WriteLine(res);
        }
    }
}
