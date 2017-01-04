using System;
using System.Numerics;

namespace _08.CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger factorialNN = 1;
            BigInteger factorialn1 = 1;
            BigInteger factorialN = 1;

            for (int i = 1; i <= 2*N; i++)
            {
                factorialNN *= i;
            }
            for (int j = 1; j <= N+1; j++)
            {
                factorialn1 *= j;
            }
            for (int l = 1; l <= N; l++)
            {
                factorialN *= l;
            }
            Console.WriteLine(factorialNN/(factorialn1 * factorialN));
        }
    }
}
