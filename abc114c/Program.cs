using System;
using System.Collections.Generic;

namespace abc114c
{
    class Program
    {
        static char[] _753 = new char[] { '7', '5', '3'};
        static long N;
        static long res = 0;

        static void Main(string[] args)
        {
            N = long.Parse(Console.ReadLine());
            Dfs("7");
            Dfs("5");
            Dfs("3");
            Console.WriteLine(res);
        }

        static void Dfs(string num) {

            if (long.Parse(num) > N) 
            {
                return;
            }

            if(num.IndexOf('7') > -1 && num.IndexOf('5') > -1 && num.IndexOf('3') > -1) res++;

            for (int i = 0; i < 3; ++i) {
                var tmp = num + _753[i];
                Dfs(tmp);
            }
        }
    }
}
