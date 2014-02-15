using System;

/*
 * 4.Sort 3 real values in descending order using nested if statements.
 */

class SortRealNumbers
{
    static void Main()
    {
        double firstNumber = 2.5;
        double secondNumber = 9;
        double thirdNumber = -3;

        if (firstNumber > secondNumber && firstNumber >thirdNumber)
        {
            Console.WriteLine(firstNumber);

            if (secondNumber > thirdNumber)
            {
                Console.WriteLine(secondNumber);
                Console.WriteLine(thirdNumber);
            }
            else
            {
                Console.WriteLine(thirdNumber);
                Console.WriteLine(secondNumber);
            }
        }


        if (secondNumber > firstNumber && secondNumber > thirdNumber )
        {
            Console.WriteLine(secondNumber);

            if (firstNumber > thirdNumber)
            {
                Console.WriteLine(firstNumber);
                Console.WriteLine(thirdNumber);
            }
            else
            {
                Console.WriteLine(thirdNumber);
                Console.WriteLine(firstNumber);
            }
        }


        if (thirdNumber > firstNumber && thirdNumber >secondNumber)
        {
            Console.WriteLine(thirdNumber);

            if (firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber);
                Console.WriteLine(secondNumber);
            }
            else
            {
                Console.WriteLine(secondNumber);
                Console.WriteLine(firstNumber);
            }
        }


    }
}

