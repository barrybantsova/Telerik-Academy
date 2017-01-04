using System;


namespace _01.SayHello
{
    class Program
    { 
        static void Main(string[] args)
        {
            string inputName = Console.ReadLine();
            PrintName(inputName);
        }

        static void PrintName(string inputName)
        {
            string concatStrings = "Hello, " + inputName + "!";
            Console.WriteLine(concatStrings);
        }

    }
}
