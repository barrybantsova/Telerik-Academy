using System;
using System.Numerics;

namespace _07.Calculate3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            BigInteger factorielN = 1;
            BigInteger factorielK = 1;
            BigInteger facNK = 1;

            for (int i = 1; i <= N; i++)
            {
                factorielN *= i;
                if (i <= K)
                {
                    factorielK *= i;
                }
               
            }
            for (int j = 1; j <= N-K; j++)
            {
                facNK*=j;
            }
            Console.WriteLine(factorielN/(factorielK*facNK));
        }
    }
}
