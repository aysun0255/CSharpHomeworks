using System;

/*
 * 3.Write a program that finds the biggest of three integers using nested if statements.
 */

class LargestNumber
{
    static void Main()
    {
        int firstNumber = 6;
        int secondNumber = 25;
        int thirdNumber = 3;
        int largestNumber = 0;

        if (firstNumber > secondNumber)
        {
            largestNumber = firstNumber;
        }
        else if (firstNumber < secondNumber)
        {
            largestNumber = secondNumber;
        }
        else if (largestNumber < thirdNumber)
        {
            largestNumber = thirdNumber;
        }

        Console.WriteLine("The largest number is : {0}",largestNumber);
    }
}

