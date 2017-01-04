using System;

namespace _10.Interval
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = n+1;i< m;i++)
            {
                if (i % 5 == 0)
                {
                    result++;
                }  
            }
            Console.WriteLine(result);
        }
    }
}
