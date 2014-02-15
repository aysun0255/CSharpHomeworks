using System;

/*
 * 11.Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.
 */

class BitPosition
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

        int bit;
        int mask = 1 << p;
        if ((v & mask) != 0)
        {
            bit = 1;
        }
        else
        {
            bit = 0;
        }

        Console.WriteLine("The value of bit in checked position is  : {0}", bit);
    }
}

