using System;

/*
 * 2.Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it.
 * Use a sequence of if statements.
 */

class SignOfProduct
{
    static void Main()
    {
        double firstNumber = 5;
        double secondNumber = 2.6;
        double thirdNumber = 4.6;


        if (firstNumber >= 0 && secondNumber >= 0 && thirdNumber >= 0)
        {
            Console.WriteLine("Sign of product is +");
        }
        else if (firstNumber < 0 || secondNumber < 0 || thirdNumber < 0)
        {
            Console.WriteLine("Sign of product is -");
        }
       
    }
}

