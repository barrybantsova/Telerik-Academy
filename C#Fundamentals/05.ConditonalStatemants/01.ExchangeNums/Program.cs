using System;

namespace _01.ExchangeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = double.Parse(Console.ReadLine());
            var second = double.Parse(Console.ReadLine());
            if (first > second)
            {
                Console.WriteLine("{0} {1}", second, first);
            }
            else
            {
                Console.WriteLine("{0} {1}", first, second);
            }

        }
    }
}
