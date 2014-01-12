using System;
using System.Numerics;

/*
 * 7.Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
 *Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.
 */


class NFibonacciNumbers
{
    static void Main(string[] args)
    {

        Console.Write("How many numbers you want to see from the Fibonacci sequence :");
        int n = int.Parse(Console.ReadLine());
        BigInteger firstSum = 0;
        BigInteger secondSum = 0;
        BigInteger sum = 1;


        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(sum);
            firstSum = secondSum;
            secondSum = sum;
            sum = firstSum + secondSum;
        }

    }
}

