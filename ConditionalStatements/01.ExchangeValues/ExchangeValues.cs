using System;

/*
 *1.Write an if statement that examines two integer variables
 *and exchanges their values if the first one is greater than the second one. 
 */

class ExchangeValues
{
    static void Main()
    {
        Console.Write("Enter first number :");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter second number :");
        int secondNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber) 
        {
            int exchangeVar = secondNumber;
            secondNumber = firstNumber;
            firstNumber = exchangeVar;
        }

        Console.WriteLine("first num {0}, second num {1}",firstNumber,secondNumber);
    }
}

