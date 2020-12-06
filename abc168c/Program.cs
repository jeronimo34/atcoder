using System;
using System.Linq;

namespace abc168c
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputs = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();

            double A = inputs[0];
            double B = inputs[1];
            double H = inputs[2];
            double M = inputs[3];

            double degA = H * 30+(M/60)*30;
            double degB = M * 6;

            var ay = Math.Sin(ToRadian(degA)) * A;
            var ax = Math.Cos(ToRadian(degA)) * A;
            var by = Math.Sin(ToRadian(degB)) * B;
            var bx = Math.Cos(ToRadian(degB)) * B;

            var res = Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by));
            Console.WriteLine(res);

        }

        public static double ToRadian(double angle)
        {
            return (double)(angle * Math.PI / 180);
        }
    }
}
