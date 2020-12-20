using System;
using System.Linq;

namespace abc167d
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] inputs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            long N = inputs[0];
            long K = inputs[1];
            long[] A = Console.ReadLine().Split(' ').Select(x => long.Parse(x)-1).ToArray();

            long pos = A[0];

            int[] visited = new int[N];
            K--;
            while (K > 0) 
            {
                K--;
                visited[pos]++;
                Console.WriteLine(pos+1);

                if (K == 0)
                {
                    Console.WriteLine(pos + 1);
                    return;
                }

                if (visited[pos] == 2) 
                {
                    pos = A[pos];
                    break;        
                }

                pos = A[pos];
            }


            long step = 0;
            while (K > 0)
            {
                K--;
                step++;
                visited[pos]++;
                Console.WriteLine(pos + 1);

                if (K == 0)
                {
                    Console.WriteLine(pos + 1);
                    return;
                }

                if (visited[pos] == 3)
                {
                    pos = A[pos];
                    break;
                }

                pos = A[pos];
            }

            

            Console.WriteLine("=================");

            if (K > 0)
            {
                long cnt = K % step;

                while (cnt-- > 0)
                {
                    Console.WriteLine(pos + 1);
                    pos = A[pos];
                }
            }

            Console.WriteLine(pos+1);
        }
    }
}
