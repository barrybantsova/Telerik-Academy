using System;

namespace _11.BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string binaryNum = Console.ReadLine();
           var result = Convert.ToInt32(binaryNum,2);
            Console.WriteLine(result);
        }
    }
}
