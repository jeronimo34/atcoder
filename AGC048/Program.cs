using System;

namespace AGC048
{
    class Program
    {
        static void Main(string[] args)
        {
            var T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; ++i) {
                var str = Console.ReadLine();

                long res = Solve(str);

                Console.WriteLine(res);
            }
        }

        static long Solve(string input) {
            var atcorder = "atcoder";
            int cursor = 0;
            var str = input.ToCharArray();
            int swapCount = 0;
            var existSolution = true;

            while (cursor < str.Length) {

                if (atcorder.Length <= cursor) 
                {
                    existSolution = true;
                    break;
                }
                else if (str[cursor] > atcorder[cursor])
                {
                    existSolution = true;
                    break;
                }
                else if (str[cursor] == atcorder[cursor]) {
                    cursor++;
                    if (str.Length < atcorder.Length && str.Length <= cursor) {
                        existSolution = false;
                        break;
                    }
                }
                else 
                {
                    //atcodeezr
                    var foundSwapTarget = false;
                    //str[cursor] < atcorder[cursor]
                    for (int i = cursor+1; i < str.Length; ++i) {
                        if (str[i] > atcorder[cursor]) {
                            //found swap target
                            var tmp = str[i];
                            str[i] = str[cursor];
                            str[cursor] = tmp;
                            swapCount += i - cursor;
                            foundSwapTarget = true;
                            break;
                        }
                    }

                    if (foundSwapTarget) {
                        existSolution = true;
                        break;
                    }

                    for (int i = cursor + 1; i < str.Length; ++i)
                    {
                        if (str[i] == atcorder[cursor])
                        {
                            //found swap target
                            var tmp = str[i];
                            str[i] = str[cursor];
                            str[cursor] = tmp;
                            swapCount += i - cursor;
                            foundSwapTarget = true;
                            cursor++;
                            break;
                        }
                    }

                    if (!foundSwapTarget) {
                        existSolution = false;
                        break;
                    }

                }                    
            }

            if (existSolution) return swapCount;
            return -1;
        }
    }
}
