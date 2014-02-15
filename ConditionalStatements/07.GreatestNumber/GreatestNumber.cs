using System;

/*
 * 7.Write a program that finds the greatest of given 5 variables.
 */

class GreatestNumber
{
    static void Main()
    {
        int firstNumber = 1;
        int secondNumber = 9;
        int fourthNumber = 14;
        int thirdNumber = 600;
        int fifthNumber = 700;
        int largestNumber = 0;


        if (firstNumber > secondNumber)
        {
            largestNumber = firstNumber;
            largestNumber = CheckNumber(fourthNumber, thirdNumber, fifthNumber, largestNumber);
        }
        else
        {
            largestNumber = secondNumber;
            largestNumber = CheckNumber(fourthNumber, thirdNumber, fifthNumber, largestNumber);
        }

        Console.WriteLine("The largest number is : {0}", largestNumber);
    }

    private static int CheckNumber(int fourthNumber, int thirdNumber, int fifthNumber, int largestNumber)
    {
        if (largestNumber < thirdNumber)
        {
            largestNumber = thirdNumber;
            if (largestNumber < fourthNumber)
            {
                largestNumber = fourthNumber;
            }
            else if (largestNumber < fifthNumber)
            {
                largestNumber = fifthNumber;
            }
        }
        return largestNumber;
    }
}

