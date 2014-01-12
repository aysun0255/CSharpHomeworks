using System;

/*
 * 12.Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:
 * n=3
 *  123
 *  234
 *  345
 **/

class PrintMatrix
{
    static void Main()
    {
        Console.Write("Enter valu for n :");
        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            for (int col = row; col < row + n; col++)
            {

                Console.Write(col);
            }
            Console.WriteLine("");
        }
    }
}

