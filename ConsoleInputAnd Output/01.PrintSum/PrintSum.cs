using System;



/*
 * 1.Write a program that reads 3 integer numbers from the console and prints their sum.
 */

class PrintSum
{
    static void Main()
    {
        Console.Write("Enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third number:");
        int thirdNumber = int.Parse(Console.ReadLine());

        int sum = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("Sum of entered numbers is :{0}",sum);

         

    }
}

