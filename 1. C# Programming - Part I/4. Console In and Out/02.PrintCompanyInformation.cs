using System;

/*A company has name, address, phone number, fax number, web site and manager. The manager has first name, 
  last name, age and a phone number.
  Write a program that reads the information about a company and its manager and prints it back on the console.*/

    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.Write("Company name: ");
            string companyName = Convert.ToString(Console.ReadLine());
            Console.Write("Company address: ");
            string companyAddress = Convert.ToString(Console.ReadLine());
            Console.Write("Phone number: ");
            string phoneNumber = Convert.ToString(Console.ReadLine());
            Console.Write("Fax number: ");
            int faxNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Web site: ");
            string webSite = Convert.ToString(Console.ReadLine());
            Console.Write("Manager first name: ");
            string managerFirstName = Convert.ToString(Console.ReadLine());
            Console.Write("Manager last name: ");
            string managerLastName = Convert.ToString(Console.ReadLine());
            Console.Write("Manager age: ");
            int managerAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Manager phone: ");
            string managerPhone = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Company name:       " + companyName);
            Console.WriteLine("Company address:    " + companyAddress);
            Console.WriteLine("Phone number:       " + phoneNumber);
            Console.WriteLine("Fax number:         " + faxNumber);
            Console.WriteLine("Web site:           " + webSite);
            Console.WriteLine("Manager first name: " + managerFirstName);
            Console.WriteLine("Manager last name:  " + managerLastName);
            Console.WriteLine("Manager age:        " + managerAge);
            Console.WriteLine("Manager phone:      " + managerPhone);
        }
    }

