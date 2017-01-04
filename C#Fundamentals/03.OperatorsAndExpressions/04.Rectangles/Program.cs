using System;

namespace _04.Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var area = width * height;
            var parameter = 2 * width + 2 * height;
            Console.WriteLine("{0:F2} {1:F2}", area,parameter);

        }
    }
}
