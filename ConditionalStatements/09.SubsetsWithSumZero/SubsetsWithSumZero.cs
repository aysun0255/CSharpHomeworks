using System;

/*
 * 9.We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0.
 * Example: 3, -2, 1, 1, 8  1+1-2=0.
 */

class SubsetsWithSumZero
{
    static void Main()
    {
        int firstNumber = 3;
        int secondNumber = -2;
        int thirdNumber = 1;
        int fourthNumber = 1;
        int fifthNumber = 8;
        //int t = Math.Sign(firstNumber*secondNumber);
       // Console.WriteLine(t);

        if (firstNumber + secondNumber + thirdNumber == 0)
        {
            Console.WriteLine(firstNumber + "" + secondNumber + "" + thirdNumber);
        }

        if (firstNumber + secondNumber + fourthNumber == 0)
        {
            Console.WriteLine(firstNumber + "" + secondNumber + "" + fourthNumber);
        }

        if (firstNumber + secondNumber + fifthNumber == 0)
        {
            Console.WriteLine(firstNumber + "" + secondNumber + "" + fifthNumber);
        }

        if (firstNumber + thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine(firstNumber + "" + thirdNumber + "" + fourthNumber);
        }

        if (firstNumber + thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine(firstNumber + "" + thirdNumber + "" + fifthNumber);
        }

        if (firstNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine(firstNumber + "" + fourthNumber + "" + fifthNumber);
        }

        if (secondNumber + thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0},{1},{2}",secondNumber,thirdNumber,fourthNumber);
        }

        if (secondNumber + thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine(secondNumber + "" + thirdNumber + "" + fifthNumber);
        }

        if (thirdNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine(thirdNumber + "" + fourthNumber + "" + fifthNumber);
        }


    }





}

