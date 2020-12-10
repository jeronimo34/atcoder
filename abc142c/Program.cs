using System;
using System.Collections.Generic;
using System.Linq;

namespace abc142c
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            var students = new List<Tuple<int, int>>();

            for (int i = 0; i < N; ++i) {
                students.Add(new Tuple<int,int>(i+1, A[i]));
            }

            students.Sort((a, b) => a.Item2 - b.Item2);
            Console.WriteLine(string.Join(' ', students.Select(x => x.Item1.ToString()).ToArray()));
        }
    }
}
