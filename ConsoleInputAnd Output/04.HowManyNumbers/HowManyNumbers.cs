using System;

/*
 * 4.Write a program that reads two positive integer numbers and prints how many numbers p
 * exist between them such that the reminder of the division by 5 is 0 (inclusive).
 * Example: p(17,25) = 2.
 */

class HowManyNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first and last number of interval:");
        Console.Write("Enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber )
        {
            int temp = 0;
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }
        int p = 0;


        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i%5 == 0)
            {
                p++;
            }
        }
        Console.WriteLine("There are {0} numbers in the interval({1},{2}) that have reminder 0 of the division by 5",p,firstNumber,secondNumber);
    }
}

