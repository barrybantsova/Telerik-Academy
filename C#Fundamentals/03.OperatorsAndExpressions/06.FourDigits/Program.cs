using System;

namespace _06.FourDigits
{
    public class Program
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            var first = input % 10000 / 1000;
            var second = input % 1000 / 100;
            var third = input % 100 / 10;
            var forth = input % 10;
            var sum = first + second + third + forth;
            Console.WriteLine(sum);
            var firstPrint = (char)(first + 48);
            var secondPrint = (char)(second + 48);
            var thirdPrint = (char)(third + 48);
            var forthPrint = (char)(forth + 48);
            Console.WriteLine("{0}{1}{2}{3}",forthPrint,thirdPrint,secondPrint,firstPrint);
            Console.WriteLine("{0}{1}{2}{3}", forthPrint, firstPrint, secondPrint, thirdPrint);
            Console.WriteLine("{0}{1}{2}{3}", firstPrint, thirdPrint, secondPrint, forthPrint);

        }
    }
}
