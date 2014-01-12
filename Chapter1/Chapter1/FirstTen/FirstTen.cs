using System;

/*
 * 9.Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
 */

class FirstTen
{
    static void Main()
    {
        int l = 2;
        int n = 5;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(l);
            Console.WriteLine(l - n);
            l += 2;
            n += 4;
        }
    }
}

