using System;

namespace _01.Leap_year
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            var result = DateTime.IsLeapYear(year);
            Console.WriteLine(result  ? "Leap" : "Common");
        }
    }
}
