using System;

namespace _03.DevideBy7And5
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            if (input % 7 == 0 && input % 5 == 0)
                Console.WriteLine("true " + input);
            else
                Console.WriteLine("false " + input);
        }
    }
}
