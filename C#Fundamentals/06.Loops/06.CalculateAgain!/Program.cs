using System;
using System.Numerics;

namespace _06.CalculateAgain_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            BigInteger result = 0;

            //N! / K!
            for (int i = 1; i <=N; i++)
            {
                factorialN *= i;
                if (i<=K)
                {
                    factorialK *= i;
                }
            }
            Console.WriteLine(factorialN/factorialK);

        }
    }
}
