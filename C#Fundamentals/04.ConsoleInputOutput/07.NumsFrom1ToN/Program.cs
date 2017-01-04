using System;

namespace _07.NumsFrom1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
