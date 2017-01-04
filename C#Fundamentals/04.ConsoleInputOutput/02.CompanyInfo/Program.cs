using System;

namespace _02.CompanyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var companyName = Console.ReadLine();
            var companyAddress = Console.ReadLine();
            var phone = Console.ReadLine();
            var faxNum = Console.ReadLine();
            var website = Console.ReadLine();
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var manegerPhone = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + companyAddress);
            Console.WriteLine("Tel. " + phone);
            if(faxNum == "")
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: " + faxNum);
            }
            Console.WriteLine("Web site: " + website);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstName, lastName, age, manegerPhone);


        }
    }
}
