using System;
using System.Collections.Generic;
using System.Linq;

namespace abc181d
{
    class Program
    {
        static void Main(string[] args)
        {
            var S = Console.ReadLine();

            var nums = new List<int>();
            var inputsCount = new int[10];
            Array.Fill(inputsCount, 0);

            for (var i = 0; i < S.Length; ++i) 
            {
                var num = int.Parse(S[i].ToString());

                if (inputsCount[num] >= 3) continue;

                inputsCount[num]++;
                nums.Add(num);
            }

            if (S.Length == 1 && S == "8") {
                Console.WriteLine("Yes");
                return;
            }

            if (S.Length == 2)
            {
                if (S == "16" || S == "61" || //16
                S == "24" || S == "42" ||//24
                S == "32" || S == "23" ||//32
                S == "40" || S == "04" ||//40
                S == "48" || S == "84" ||//48
                S == "56" || S == "65" ||//56
                S == "64" || S == "46" ||//64
                S == "72" || S == "27" ||//72
                S == "80" || S == "08" ||//80
                S == "88" || //88
                S == "96" || S == "69" //96
                ) {
                    Console.WriteLine("Yes");
                    return;
                }
            }


                for (var i = 0; i < nums.Count; ++i) 
            {
                for (var j = 0; j < nums.Count; ++j)
                {
                    for (var k = 0; k < nums.Count; ++k)
                    {
                        if (i == j) continue;
                        if (j == k) continue;
                        if (i == k) continue;

                        if ((nums[i] * 100 + nums[j] * 10 + nums[k]) % 8 == 0) {
                            Console.WriteLine("Yes");
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("No");
        }
    }
}
