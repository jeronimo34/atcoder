using System;
using System.Collections.Generic;
using System.Linq;

namespace PAST202010E
{
    class Program
    {
        static bool[] visited;
        static List<string> anagrams = new List<string>();

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();

            visited = new bool[N];

            for (int i = 0; i < N; ++i)
            {
                Array.Fill(visited, false);
                string res = "" + S[i];
                visited[i] = true;
                Dfs(i, S, res);
            }

            foreach (var x in anagrams)
            {
                if (x != S && x != new string(S.Reverse().ToArray()))
                {
                    Console.WriteLine(x);
                    return;
                }
            }
           
            Console.WriteLine("None");
        }

        static void Dfs(int v, string s, string res) 
        {
            if (visited.All(x => x == true))
            {
                anagrams.Add(res);
                return;
            }

            for (int i = 0; i < s.Length; ++i) 
            {
                if (visited[i]) continue;
                var tmp = res;
                res += s[i];
                visited[i] = true;
                
                Dfs(i, s, res);

                res = tmp;
                visited[i] = false;
            }
        }
    }
}
