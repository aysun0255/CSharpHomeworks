using System;

/*
 * 1.Write a program that prints all the numbers from 1 to N.
 */

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            
                Console.WriteLine(i);
            
        }
    }
}

