using System;

class FibonacciNumbers
{ 
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long[] fibNumbers = new long[n + 1];
        fibNumbers[0] = 0;
        fibNumbers[1] = 1;

        if (n >= 1 && n <= 50)
        {
            if (n > 1)
            {
                for (int i = 2; i < n; i++)
                {
                    fibNumbers[1] = 1;
                    fibNumbers[i] = fibNumbers[i - 2] + fibNumbers[i - 1];
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(fibNumbers[i]);
                if (i >= 0 && i < n - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}

