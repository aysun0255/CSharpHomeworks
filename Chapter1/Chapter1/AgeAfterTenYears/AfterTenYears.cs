using System;

/*
 * 12.* Write a program to read your age from the console and print how old you will be after 10 years.
 */


class AfterTenYears
{
    static void Main()
    {
        Console.Write("Enter your age:");
        int age = int.Parse(Console.ReadLine());
        if (age >= 0 && age < 120)//checking the entered age
        {
            age += 10;
            Console.WriteLine("After 10 years you will be {0} years old.", age);
        }
        else 
        {
            Console.WriteLine("You have entered invalid value for age!");
        }
    }
}

