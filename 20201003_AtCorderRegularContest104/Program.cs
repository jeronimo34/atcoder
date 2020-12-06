using System;

namespace _20201003_AtCorderRegularContest104
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var inputs = line.Split(' ');

            var N = int.Parse(inputs[0]);
            var S = inputs[1];

            int res = 0;
            for (var i = 0; i < N; ++i) {
                int atCount = 0;
                int cgCount = 0;

                for (var j = i; j < N; ++j) 
                {
                    if (S[j] == 'A') atCount++;
                    if (S[j] == 'T') atCount--;
                    if (S[j] == 'C') cgCount++;
                    if (S[j] == 'G') cgCount--;

                    if (atCount == 0 && cgCount == 0) res++;
                }
            }

            Console.WriteLine(res);
        }

    }
}
