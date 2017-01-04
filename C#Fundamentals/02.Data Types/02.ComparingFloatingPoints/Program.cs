using System;

namespace _02.ComparingFloatingPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = double.Parse(Console.ReadLine());
            var second = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            var max = Math.Max(first, second);
            var min = Math.Min(first, second);
            if ((max - min) < eps)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
           
            

        }
    }
}
