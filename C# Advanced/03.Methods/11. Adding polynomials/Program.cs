using System;
using System.Linq;

namespace _11.AddingPolynomials
{
    class Program
    {
        static int n;
        static int[] firstValues;
        static int[] secondValues;
        static int[] firstPolynomials;
        static int[] secondPolynomials;
        static string[] result;

        static void Main(string[] args)
        { 
            n = int.Parse(Console.ReadLine());
            firstValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            secondValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            firstPolynomials = new int[n];
            secondPolynomials = new int[n];
            result = new string[n];
            
            PolinomialsCalc();
            
            Console.WriteLine(string.Join(" ", result));
        }

        static void PolinomialsCalc()
        {

            
            for (int i = 0; i < n; i++)
            {
                firstPolynomials[i] = firstValues[n - i - 1];
            }
           
            for (int i = 0; i < n; i++)
            {
                secondPolynomials[i] = secondValues[n - i - 1];
            }
           
            for (int i = 0; i < n; i++)
            {
                result[n - i - 1] = (firstPolynomials[i] + secondPolynomials[i]).ToString();
            }
        }
    }
}