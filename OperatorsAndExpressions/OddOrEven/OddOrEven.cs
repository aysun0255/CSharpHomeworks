using System;

/*
 *1.Write an expression that checks if given integer is odd or even. 
 */

class OddOrEven
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

        if (userInput % 2 == 0)
        {
            Console.WriteLine("Entered number is even.");
        }
        else
        {
            Console.WriteLine("Entered number is odd.");
        }
    }
}

