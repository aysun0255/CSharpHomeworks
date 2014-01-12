using System;

/*
 * 8.Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n],
 * each on a single line.
 */

    class PrintInterval
    {
        static void Main()
        {
            Console.Write("Enter value for n:");
            int n;
            bool isNumber = int.TryParse(Console.ReadLine(), out n);
            while (!isNumber)
            {
                Console.Write("Enter value for n:");
                isNumber = int.TryParse(Console.ReadLine(), out n);

            }

            if (n>0)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }

            if (n <0)
            {
                for (int i = 1; i >= n; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

