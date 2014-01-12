using System;
using System.Threading;
using System.Globalization;


/*
 * 3.Write a program that safely compares floating-point numbers with precision of 0.000001.
 * Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true
 * Decimal separator is "."!
 */

class CompareFloatPoint
{
    static void Main()
    {

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;//This code ensure that the decimal separator is "." 

        Console.WriteLine("Enter two numbers to compare:");
        Console.Write("First number:");
        float firstNumber = float.Parse(Console.ReadLine());
        Console.Write("Second number:");
        float secondNumber = float.Parse(Console.ReadLine());
        bool areEqual = (firstNumber == secondNumber);

        Console.WriteLine("a = {0} , b={1},  areEqual={2} ",
            firstNumber, secondNumber, areEqual);
    }
}

