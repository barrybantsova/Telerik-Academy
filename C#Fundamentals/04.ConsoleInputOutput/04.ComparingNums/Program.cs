using System;

namespace _04.ComparingNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var greater = Math.Max(a,b);
            Console.WriteLine(greater);

        }
    }
}
