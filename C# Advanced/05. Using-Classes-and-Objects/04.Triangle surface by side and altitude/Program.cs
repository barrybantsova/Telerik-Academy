using System;


namespace _04.Triangle_surface_by_side_and_altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideLength = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}",(sideLength *altitude)/2);
        }
    }
}
