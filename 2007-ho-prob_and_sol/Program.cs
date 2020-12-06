using System;
using System.Collections.Generic;
using System.Linq;

namespace _2007_ho_prob_and_sol
{
    class Program
    {
        public class Point
        {

            public Point() { }
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public int x, y;


        }

        public static Point Add(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }

        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            var map = new Dictionary<string, int>();


            List<Point> points = new List<Point>();

            for (var i = 0; i < N; ++i)
            {
                var inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                map[inputs[0] + "," + inputs[1]] = 1;
                points.Add(new Point() { x = inputs[0], y = inputs[1] });
            }

            int res = 0;
            for (var i = 0; i < points.Count; ++i)
            {
                var p1 = points[i];
                for (var j = 0; j < points.Count; ++j)
                {
                    if (i == j) continue;

                    var p2 = points[j];

                    var v1 = new Point() { x = p2.x - p1.x, y = p2.y - p1.y };
                    var v2 = new Point(-v1.y, v1.x);
                    var v3 = new Point(-v1.x, -v1.y);

                    var p3 = Add(p2, v2);
                    var p4 = Add(p3, v3);

                    if (p3.x < 0 || 5000 < p3.x) continue;
                    if (p3.y < 0 || 5000 < p3.y) continue;
                    if (p4.x < 0 || 5000 < p4.x) continue;
                    if (p4.y < 0 || 5000 < p4.y) continue;

                    if (map.ContainsKey(p3.x + "," + p3.y) && map.ContainsKey(p4.x + "," + p4.y))
                    {
                        var s = v1.x * v1.x + v1.y * v1.y;
                        res = Math.Max(res, s);
                    }
                }
            }

            Console.WriteLine(res);
        }
    }
}