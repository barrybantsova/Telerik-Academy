using System;

namespace _01.EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("even " + input);
            }
            else
                Console.WriteLine("odd " + input);
        }
    }
}
