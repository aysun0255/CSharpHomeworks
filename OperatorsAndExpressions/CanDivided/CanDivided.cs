using System;

/**
 * 2.Write a boolean expression that checks for given integer 
 * if it can be divided (without remainder) by 7 and 5 in the same time.
 */

class CanDivided
{
    static void Main()
    {
        int userInput;
        bool isNumber = false;

        do
        {
            Console.Write("Enter number to check:");
            isNumber = int.TryParse(Console.ReadLine(), out userInput);
            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");
            }
        }
        while (!isNumber);

        bool canDivided = (userInput % 5 == 0) && (userInput % 7 == 0);

        Console.WriteLine("Can entered number  be divided (without remainder) by 7 and 5 in the same time:{0}",canDivided);
    }
}

