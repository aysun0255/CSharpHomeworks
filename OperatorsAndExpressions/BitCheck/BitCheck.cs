using System;

/*
 * 10.Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1  false.
 */

class BitCheck
{
    static void Main()
    {
        int v;
        int p;
        bool isNumber = false;

        do
        {
            Console.Write("Enter number to check:");
            isNumber = int.TryParse(Console.ReadLine(), out v);
            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");
            }
        }
        while (!isNumber);
        isNumber = false;

        do
        {
            Console.Write("Enter position to check:");
            isNumber = int.TryParse(Console.ReadLine(), out p);
            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");
            }
        }
        while (!isNumber);

        int mask = 1 << p;
        bool isCheckedBit = (v & mask) != 0;
        Console.WriteLine("Is the value of checked position is 1 : {0}", isCheckedBit);
        Console.WriteLine(Convert.ToString(v, 2));

    }
}

