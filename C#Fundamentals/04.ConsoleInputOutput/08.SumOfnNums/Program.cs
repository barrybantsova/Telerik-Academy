using System;

namespace _08.SumOfnNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double sum = 0.0;

                for (int i = 1; i <= n; i++)
                {
                    double next = double.Parse(Console.ReadLine());
                    sum += next;
                }
                    Console.WriteLine(sum);
                
            
            
        }
    }
}
