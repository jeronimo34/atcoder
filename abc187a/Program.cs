using System;
using System.Linq;

namespace abc187a
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());//.ToCharArray().ToList();
            
            int a = 0;
            for (int i = 0; i < A.Length; ++i) {
                var inputs = Console.ReadLine().Split(' ');//.Select(x => long.Parse(x)).ToArray();
            var (A, B) = (inputs[0].ToCharArray(), inputs[1].ToCharArray());

                a += int.Parse(""+ A[i]);
            }

            int b = 0;
            for (int i = 0; i < B.Length; ++i)
            {
                b += int.Parse("" + B[i]);
            }

            Console.WriteLine(Math.Max(a, b));

        }
    }
}
