using System;
using System.Linq;

namespace _20201011AtCoderRegularContest105
{
    class Program
    {
        static void Main(string[] args)
        {
            var line1 = Console.ReadLine();
            var N = long.Parse(line1);
            var line2 = Console.ReadLine();

            var inputs = line2.Split(' ');

            var array = new long[N];

            for (var i = 0; i < N; ++i) array[i] = int.Parse(inputs[i]);

            var minval = array.Min();
            for (var i = 0; i < N; ++i) {
                minval = gcd(array[i], minval);
            }

            Console.WriteLine(minval);

        }

        static long gcd(long x, long y)
        { 
            return (x % y > 0) ? gcd(y, x % y) : y;
        }

        void SolveA() {
            var line = Console.ReadLine();
            var inputs = line.Split(' ');

            var array = new long[4];

            for (int i = 0; i < 4; ++i)
            {
                array[i] = int.Parse(inputs[i]);
            }

            var sum = array.Sum();

            bool res = false;
            for (int i = 0; i < 2; ++i)
                for (int j = 0; j < 2; ++j)
                    for (int k = 0; k < 2; ++k)
                        for (int l = 0; l < 2; ++l)
                        {
                            long tsum = 0;
                            if (i == 1) tsum += array[0];
                            if (j == 1) tsum += array[1];
                            if (k == 1) tsum += array[2];
                            if (l == 1) tsum += array[3];

                            if (2 * tsum == sum)
                            {
                                res = true;
                            }
                        }

            if (res) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
