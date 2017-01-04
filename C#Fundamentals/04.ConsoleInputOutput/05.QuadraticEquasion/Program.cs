using System;

namespace _05.QuadraticEquasion
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            var discriminant = b * b - (4 * a * c);

            if (discriminant > 0) { 
                var x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            var x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            var greater = Math.Max(x1, x2);
                var lower = Math.Min(x1, x2);
                
                Console.WriteLine("{0:F2}", lower);
                Console.WriteLine("{0:F2}",greater);

            }
            if (discriminant == 0)
            {
                var onlyX = -b / (2 * a);
                Console.WriteLine("{0:F2}",onlyX);
            }
            else if (discriminant < 0)
            {
                Console.WriteLine("no real roots");
            }


        }
    }
}
