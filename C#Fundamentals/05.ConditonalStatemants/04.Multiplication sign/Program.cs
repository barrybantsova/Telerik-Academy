using System;

namespace _04.Multiplication_sign
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = double.Parse(Console.ReadLine());
            var second = double.Parse(Console.ReadLine());
            var third = double.Parse(Console.ReadLine());

            var multiply = first * second * third;
            if(multiply > 0)
            {
                Console.WriteLine("+");
            }
           else if(multiply < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("0");
            }

            
        }
    }
}
