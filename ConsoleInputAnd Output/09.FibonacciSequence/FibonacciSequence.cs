using System;
using System.Numerics;//for BigInteger type

/*
 * 9.Write a program to print the first 100 members of the sequence of Fibonacci:
 * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
 */

class FibonacciSequence
{
    static void Main()
    {
        checked
        {
            BigInteger f0 = 0;
            BigInteger f1 = 1;
            BigInteger temp = 0;
            Console.WriteLine(f0);
            Console.WriteLine(f1);
            for (int i = 2; i <= 100; i++)
            {
                temp = f1;
                f1 = f0 + f1;
                f0 = temp;
                Console.WriteLine(f1);
            }
        }
    }
}

