using System;

/*
 * 3.A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
 * Write a program that reads the information about a company and its manager and prints them on the console.
 */
    class CompanyInfo
    {
        static void Main()
        {
            Console.Write("Enter company name :");
            string name = Console.ReadLine();
            Console.Write("Enter company adress:");
            string adress = Console.ReadLine();
            Console.Write("Enter phone number:");
            string phoneNumber = Console.ReadLine();
            Console.Write("Enter fax number:");
            string faxNumber = Console.ReadLine();
            Console.Write("Enter website :");
            string website = Console.ReadLine();
            Console.Write("Enter manager first name:");
            string mFirstName = Console.ReadLine();
            Console.Write("Enter manager last name:");
            string mLastName = Console.ReadLine();
            Console.Write("Enter manager phone number:");
            string mPhoneNumber = Console.ReadLine();
            Console.Write("Enter manager age:");
            string mAge = Console.ReadLine();


            Console.WriteLine("Company name:{0}",name);
            Console.WriteLine("Company adress:{0}", adress);
            Console.WriteLine("Company phone number:{0}", phoneNumber);
            Console.WriteLine("Company fax number:{0}", faxNumber);
            Console.WriteLine("Company website:{0}", website);
            Console.WriteLine("Company manager first name:{0}", mFirstName);
            Console.WriteLine("Company manager last name :{0}", mLastName);
            Console.WriteLine("Company manager age:{0}", mAge);
            Console.WriteLine("Company manager phone number:{0}", mPhoneNumber);






        }
    }

