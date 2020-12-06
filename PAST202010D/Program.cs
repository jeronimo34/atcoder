using System;
using System.Linq;

namespace PAST202010D
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine().ToCharArray();

            int x = 0;
            int y = 0;

            while (!IsCompleted(N, S))
            {
                //操作Aを実行した場合増える忍者の数
                var a = 0;
                for (int i = 1; i < S.Length; ++i)
                {
                    if (S[i - 1] == '.' && S[i] == '#') a++;
                }

                //操作Bを実行した場合増える忍者の数
                var b = 0;
                for (int i = 0; i < S.Length - 1; ++i)
                {
                    if (S[i] == '#' && S[i + 1] == '.') b++;
                }

                if (a > b)
                {
                    //操作A実行
                    x++;
                    for (int i = 1; i < S.Length; ++i)
                    {
                        if (S[i - 1] == '.' && S[i] == '#')
                        {
                            S[i - 1] = '#';
                        }
                    }
                }
                else
                {
                    //操作B実行
                    y++;
                    for (int i = N - 2; i >= 0; --i)
                    {
                        if (S[i] == '#' && S[i + 1] == '.')
                        {
                            S[i + 1] = '#';
                        }
                    }
                }
            }

            Console.WriteLine(string.Format("{0} {1}",x,y));

        }

        static bool IsCompleted(int N, char[] s) 
        {
            var i = 0;
            var tmp = "";
            while (i++ < N) tmp += "#";

            if (new string(s) == tmp) return true;
            return false;
        }
    }
}
