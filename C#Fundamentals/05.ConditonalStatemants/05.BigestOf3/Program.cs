using System;

namespace _05.BigestOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = double.Parse(Console.ReadLine());
            var second = double.Parse(Console.ReadLine());
            var third = double.Parse(Console.ReadLine());

            var firstMax = Math.Max(first, second);
            var secondMax = Math.Max(second, third);
            var result = Math.Max(firstMax, secondMax);
            Console.WriteLine(result);
        }
    }
}
