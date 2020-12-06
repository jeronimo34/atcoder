using System;
using System.Collections.Generic;
using System.Linq;

namespace abc181c
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = double.Parse(Console.ReadLine());
            long res = 0;

            List<Point> points = new List<Point>();
            for (var i = 0; i < N; ++i)
            {
                var inputs = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();
                var tx = inputs[0];
                var ty = inputs[1];

                Point p = new Point()
                {
                    x = tx,
                    y = ty
                };

                points.Add(p);
            }

            for (var i = 0; i < N; ++i) 
            {
                for (var j = 0; j < N; ++j)
                {
                    for (var k = 0; k < N; ++k)
                    {
                        if (i == j) continue;
                        if (j == k) continue;
                        if (i == k) continue;

                        var p1 = points[i];
                        var p2 = points[j];
                        var p3 = points[k];


                        if (p2.x - p1.x == 0 || p3.x - p1.x == 0) 
                        {
                            if (p2.x - p1.x == 0 && p3.x - p1.x == 0) {
                                Console.WriteLine("Yes");
                                return;
                            }
                            else
                            {
                                continue;
                            }
                        }

                        //ABの傾き
                        var abIntercept = (p2.y - p1.y) / (p2.x - p1.x);

                    　　//ACの傾き
                        var acIntercept = (p3.y - p1.y) / (p3.x - p1.x);

                        if (abIntercept == acIntercept) 
                        {
                            Console.WriteLine("Yes");
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("No");

        }

        class Point {
            public double x;
            public double y;
        }
    }
}
