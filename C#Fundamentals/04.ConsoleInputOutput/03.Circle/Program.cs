using System;

namespace _03.Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            var parameter = 2 * Math.PI * r;
            Console.WriteLine("{0:F2} {1:F2}", parameter, area);
        }
    }
}
