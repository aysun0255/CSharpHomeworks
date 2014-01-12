using System;
/*
 * 14.* Write a program that reads a positive integer number N (N < 20) from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.
 */

class NumbersArranged
{
    static void Main()
    {

        Console.Write("Enter value for n:");
        int n = int.Parse(Console.ReadLine());
        int[,] array = new int[n, n];


        //preparing the array 
        for (int i = 0; i < n; i++)
        {
            array[0, i] = i + 1;

        }
        for (int i = 1; i < n; i++)
        {
            array[i, n - 1] = array[i - 1, n - 1] + 1;
        }
        for (int i = n - 2; i >= 0; i--)
        {
            array[n - 1, i] = array[n - 1, i + 1] + 1;
        }
        for (int i = n - 2; i > 0; i--)
        {
            array[i, 0] = array[i + 1, 0] + 1;
        }
        for (int i = 1; i < n - 1; i++)
        {
            array[1, i] = array[1, i - 1] + 1;
        }
        for (int i = 2; i < n - 1; i++)
        {
            array[i, n - 2] = array[i - 1, n - 2] + 1;
        }
        for (int i = n - 3; i > 0; i--)
        {
            array[n - 2, i] = array[n - 2, i + 1] + 1;
        }

        //printing the array
       
     
        for (int i = 0; i < n; i++)
        {
            Console.Write("|");
            for (int l = 0; l < n; l++)
            {
                Console.Write(array[i,l]);
                if (array[i,l] >= 10)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write(" |");
                }
                
            }
            Console.WriteLine("");
            
        }
    }
}

