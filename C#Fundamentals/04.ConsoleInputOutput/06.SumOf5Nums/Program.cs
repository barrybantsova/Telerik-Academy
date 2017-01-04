using System;

namespace _06.SumOf5Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
