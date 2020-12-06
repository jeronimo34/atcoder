using System;

namespace arc065a
{
    class Program
    {
        static void Main(string[] args)
        {
            var S = Console.ReadLine();
            var S2 = S;
            var tmp = "";

            for (var i = S.Length - 1; i >= 0; --i) {
                tmp = S[i]+tmp;

                if (tmp == "dreamer" ||
                    tmp == "eraser" ||
                    tmp == "dream" ||
                    tmp == "erase")
                {
                    tmp = "";
                    S2 = S2.Substring(0, i);
                }
            }
            if (S2 == "") Console.WriteLine("YES");
            else Console.WriteLine("NO");

        }
    }
}
