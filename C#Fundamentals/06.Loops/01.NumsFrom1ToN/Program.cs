using System;

namespace _01.NumsFrom1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            for(int i = 1; i<= n; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
