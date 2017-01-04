using System;

namespace _05.Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double S = 1+1/x ;
            long factoriel = 1;
            // S = 1 + 1!/x + 2!/x2 + … + N!/xN
            for (int i = 2; i <=N; i++)
            {
                factoriel *= i;
                double pow = Math.Pow(x, i);
                S+=(factoriel / pow);

            }
            Console.WriteLine("{0:F5}",S);
        }
    }
}
