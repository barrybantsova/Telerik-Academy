using System;
using System.Linq;

namespace _03.EnglishDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string lastDigit = GetLastDigit(n);
            Console.WriteLine(lastDigit);
        }
        static string GetLastDigit(int n)
        {
            string lastDigit = null;
            int temp = 0;
            temp = n % 10;
            switch (temp)
            {
                case 0: lastDigit = "zero"; break;
                case 1: lastDigit = "one"; break;
                case 2: lastDigit = "two"; break;
                case 3: lastDigit = "three"; break;
                case 4: lastDigit = "four"; break;
                case 5: lastDigit = "five"; break;
                case 6: lastDigit = "six"; break;
                case 7: lastDigit = "seven"; break;
                case 8: lastDigit = "eight"; break;
                case 9: lastDigit = "nine"; break;
            }
            return lastDigit;
        }
    }
}
