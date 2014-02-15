using System;

class NumberManupulation
{
    static void Main()
    {
        int fourDigitNumber;
        bool isNumber = false;

        do
        {
            Console.Write("Enter four-digit number:");
            isNumber = int.TryParse(Console.ReadLine(), out fourDigitNumber);
            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");
            }
        }
        while (!isNumber);

        string enteredNumber = fourDigitNumber.ToString();
        int[] numbers = { 
                          (int)Char.GetNumericValue(enteredNumber[0]), (int)Char.GetNumericValue(enteredNumber[1]),
                          (int)Char.GetNumericValue(enteredNumber[2]), (int)Char.GetNumericValue(enteredNumber[3]) 
                        };

        Console.WriteLine(numbers[0] + numbers[1] + numbers[2] + numbers[3]);
        Console.WriteLine("" + numbers[3] + numbers[2] + numbers[1] + numbers[0]);
        Console.WriteLine("" + numbers[3] + numbers[0] + numbers[1] + numbers[2]);
        Console.WriteLine("" + numbers[0] + numbers[2] + numbers[1] + numbers[3]);
    }
}

