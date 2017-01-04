using System;


namespace _05.Triangle_surface_by_three_sides
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            double result = triangle.getSurface();
            Console.WriteLine("{0:F2}",result);

        }
    }
    class Triangle
    {
        public double firstSide;
        public double secondSide;
        public double thirdSide;

        public double getSurface()
        {
            firstSide = double.Parse(Console.ReadLine());
            secondSide = double.Parse(Console.ReadLine());
            thirdSide = double.Parse(Console.ReadLine());
            double p = (firstSide + secondSide +thirdSide) / 2;
            double result = Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p -thirdSide));
            return result;
        }

    }
}
