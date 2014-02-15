using System;

/*
 * 4.Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true
 */

class ThirdDigit
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

        bool isThirdSeven = (userInput / 100) % 10 == 7;
        Console.WriteLine("Is third number 7 :{0}", isThirdSeven);
    }
}

