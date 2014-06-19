using System;

class CompanyAndManager
    {
        static void Main()
        {
            Console.Write("Please enter the name of the company:");
            string nameCompany = Console.ReadLine();

            Console.Write("Please enter the address of the company:");
            string addressCompany = Console.ReadLine();

            Console.Write("Please enter the phone number of the company:");
            string phoneCompany = Console.ReadLine();
            int companyPhone = int.Parse(phoneCompany);

            Console.Write("Please enter the fax number of the company:");
            string faxCompany = Console.ReadLine();
            int fax = int.Parse(faxCompany);

            Console.Write("Please enter the website of the company:");
            string websiteCompany = Console.ReadLine();

            Console.Write("Please enter the first name of the manager:");
            string firstName = Console.ReadLine();

            Console.Write("Please enter the last name of the manager:");
            string lastName = Console.ReadLine();

            Console.Write("Please enter the age of the manager:");
            string ageManager = Console.ReadLine();
            int age = int.Parse(ageManager);

            Console.Write("Please enter the phone number of the manager:");
            string phoneManager = Console.ReadLine();
            int managerPhone = int.Parse(phoneCompany);

            Console.Write("Name of the company is:" + nameCompany);
            Console.Write("The address of the company is:" + addressCompany);
            Console.Write("The phone number of the company is:" + companyPhone);
            Console.Write("The fax number of the company:" + fax);
            Console.Write("The website of the company is:" + websiteCompany);
            Console.Write("The first name of the manager is:" + firstName);
            Console.Write("The last name of the manager is:" + lastName);
            Console.Write("The age of the manager is:" + age);
            Console.Write("The phone number of the manager is:" + managerPhone);
        }
    }

