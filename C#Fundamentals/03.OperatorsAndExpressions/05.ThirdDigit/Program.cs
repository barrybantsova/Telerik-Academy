using System;

namespace _05.ThirdDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var n = input % 1000;
            if (n / 100 == 7)
                Console.WriteLine("true");
            else
                Console.WriteLine("false " +n/100 );
        }
    }
}
