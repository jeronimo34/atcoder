using System;

namespace abc122b
{
    class Program
    {
        static void Main(string[] args)
        {
            var S = Console.ReadLine();
            var res = 0;

            for (var i = 0; i < S.Length; ++i) {

                var tres = 0;
                for (var j = i; j < S.Length; ++j) {
                    if (S[j] == 'A' || S[j] == 'C' || S[j] == 'G' || S[j] == 'T')
                    {
                        tres++;
                    }
                    else break;
                }

                if (res < tres) res = tres;
            }

            Console.WriteLine(res);
        }
    }
}
