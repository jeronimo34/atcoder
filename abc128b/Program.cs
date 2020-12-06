using System;
using System.Collections.Generic;
using System.Linq;

namespace abc128b
{
    class Program
    {
        class Shop {
            public string city;
            public int point;
            public int index;
        }

        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            List<Shop> shops = new List<Shop>();

            for (var i = 0; i < N; ++i)
            {
                var inputs = Console.ReadLine().Split(' ');
                var s = inputs[0];
                var p = int.Parse(inputs[1]);

                Shop shop = new Shop() {
                    city = s,
                    point = p, 
                    index = i+1
                };

                shops.Add(shop);
            }

            shops.Sort((a, b) => 
            a.city != b.city ? a.city.CompareTo(b.city) : 
            b.point - a.point);

            for (var i = 0; i < N; ++i) Console.WriteLine(shops[i].index);
        }
    }
}
