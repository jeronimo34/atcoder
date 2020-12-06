using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace abc85d
{
    class Program
    {
        class Attack {
            public long damage;
            public bool canRepeat;
        }
        static void Main(string[] args)
        {

            var inputs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            var N = inputs[0];
            var H = inputs[1];

            //N = 10 << 5;
            //H = 10 << 9;
            List<Attack> attacks = new List<Attack>();

            for (var i = 0; i < N; ++i) {
                inputs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
                //inputs[0] = 999999999;
                //inputs[1] = 1000000000;

                attacks.Add(new Attack() { damage = inputs[0], canRepeat = true });
                attacks.Add(new Attack() { damage = inputs[1], canRepeat = false });
            }

            attacks.Sort((a,b) => Math.Sign( b.damage-a.damage));

            long sumDamage = 0;
            long res = 0;
            for (var i = 0; i < attacks.Count(); ++i) {

                var attack = attacks[i];
                if (attack.canRepeat)
                {
                    /*
                    var attackCount = (long)Math.Ceiling((double)(H - sumDamage) / attack.damage);
                    res += attackCount;
                    sumDamage += attack.damage * attackCount;
                    */
                    while (sumDamage < H)
                    {
                        sumDamage += attack.damage;
                        res++;
                    }
                }
                else {
                    sumDamage += attack.damage;
                    res++;
                }

                if (sumDamage >= H) {
                    Console.WriteLine(res);
                    return;
                }
            }
        }
    }
}
