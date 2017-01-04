using System;

namespace _09.MatrixOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i =1; i <= N; i++)
            {
                for (int j = i; j <N+i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
