using System;

/*
 * 7.Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 
 */

class GetNNumbers
{
    static void Main()
    {
        Console.Write("Enter value for n:");
        int n = int.Parse(Console.ReadLine());
        int numberValue;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number:");
            numberValue = int.Parse(Console.ReadLine());
            sum += numberValue;
            
        }

        Console.WriteLine("Sum of entered numbers is:{0}",sum);
    }
}

