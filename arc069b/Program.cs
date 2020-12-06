using System;
using System.Linq;

namespace arc069b
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = long.Parse(Console.ReadLine());
            var S = Console.ReadLine().ToArray();

            /*
            N = 100000;
            var s = "";
            for (var i = 0; i < 100000;++i) {
                s += "o";
            }
            S = s.ToArray();*/

            var animals = new char[N];
            animals[0] = 'S';
            animals[1] = 'S';
            ExpectAnimals(ref animals, S);

            if (ConfirmAnimals(animals, S)) {
                Console.WriteLine(animals);
                return;
            }

            animals = new char[N];
            animals[0] = 'W';
            animals[1] = 'W';
            ExpectAnimals(ref animals, S);

            if (ConfirmAnimals(animals, S))
            {
                Console.WriteLine(animals);
                return;
            }

            animals = new char[N];
            animals[0] = 'S';
            animals[1] = 'W';
            ExpectAnimals(ref animals, S);

            if (ConfirmAnimals(animals, S))
            {
                Console.WriteLine(animals);
                return;
            }

            animals = new char[N];
            animals[0] = 'W';
            animals[1] = 'S';
            ExpectAnimals(ref animals, S);

            if (ConfirmAnimals(animals, S))
            {
                Console.WriteLine(animals);
                return;
            }

            Console.WriteLine("-1");
        }

        static void ExpectAnimals(ref char[] ans, Char[] input) {
            var S = input;

            for (var i = 2; i < S.Length; ++i)
            {
                char nextChar = 'S';
                if (S[i - 1] == 'o')
                {
                    if (ans[i - 1] == 'S' && ans[i - 2] == 'S')
                    {
                        nextChar = 'S';
                    }
                    else if (ans[i - 1] == 'W' && ans[i - 2] == 'W')
                    {
                        nextChar = 'S';
                    }
                    else if (ans[i - 1] == 'S' && ans[i - 2] == 'W')
                    {
                        nextChar = 'W';
                    }
                    else if (ans[i - 1] == 'W' && ans[i - 2] == 'S')
                    {
                        nextChar = 'W';
                    }
                }
                else if (S[i - 1] == 'x')
                {
                    if (ans[i - 1] == 'S' && ans[i - 2] == 'S')
                    {
                        nextChar = 'W';
                    }
                    else if (ans[i - 1] == 'W' && ans[i - 2] == 'W')
                    {
                        nextChar = 'W';
                    }
                    else if (ans[i - 1] == 'S' && ans[i - 2] == 'W')
                    {
                        nextChar = 'S';
                    }
                    else if (ans[i - 1] == 'W' && ans[i - 2] == 'S')
                    {
                        nextChar = 'S';
                    }
                }
                ans[i] = nextChar;
            }
        }

        static bool ConfirmAnimals(char[] tanimals, Char[] tinput) 
        {
            var input = tinput.Last() + new string(tinput) + tinput.First();
            var animals = tanimals.Last() + new string(tanimals) + tanimals.First();

            var i = 1;
            if (input[i] == 'o')
            {
                if (!((animals[i - 1] == 'S' && animals[i] == 'S' && animals[i + 1] == 'S') ||
                    (animals[i - 1] == 'W' && animals[i] == 'S' && animals[i + 1] == 'W') ||
                    (animals[i - 1] == 'W' && animals[i] == 'W' && animals[i + 1] == 'S') ||
                    (animals[i - 1] == 'S' && animals[i] == 'W' && animals[i + 1] == 'W')))
                {
                    return false;
                }
            }
            else
            {
                if (!((animals[i - 1] == 'W' && animals[i] == 'S' && animals[i + 1] == 'S') ||
                        (animals[i - 1] == 'S' && animals[i] == 'S' && animals[i + 1] == 'W') ||
                        (animals[i - 1] == 'W' && animals[i] == 'W' && animals[i + 1] == 'W') ||
                        (animals[i - 1] == 'S' && animals[i] == 'W' && animals[i + 1] == 'S')))
                {
                    return false;
                }
            }

            i = animals.Length-2;
            if (input[i] == 'o')
            {
                if (!((animals[i - 1] == 'S' && animals[i] == 'S' && animals[i + 1] == 'S') ||
                    (animals[i - 1] == 'W' && animals[i] == 'S' && animals[i + 1] == 'W') ||
                    (animals[i - 1] == 'W' && animals[i] == 'W' && animals[i + 1] == 'S') ||
                    (animals[i - 1] == 'S' && animals[i] == 'W' && animals[i + 1] == 'W')))
                {
                    return false;
                }
            }
            else
            {
                if (!((animals[i - 1] == 'W' && animals[i] == 'S' && animals[i + 1] == 'S') ||
                        (animals[i - 1] == 'S' && animals[i] == 'S' && animals[i + 1] == 'W') ||
                        (animals[i - 1] == 'W' && animals[i] == 'W' && animals[i + 1] == 'W') ||
                        (animals[i - 1] == 'S' && animals[i] == 'W' && animals[i + 1] == 'S')))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
