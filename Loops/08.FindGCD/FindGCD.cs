using System;

/*
 * 8.Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
 * Use the Euclidean algorithm (find it in Internet).
 */

class FindGCD
{
    static void Main()
    {
        Console.Write("Enter first number:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        int b = int.Parse(Console.ReadLine());


        /*function gcd(a, b)
         while a ≠ b
        if a > b
        a = a - b
        else
        b = b - a
        return a 
         * -This is Euclid algorithm.
         * */

        while (a!=b)
        {
            if (a>b)
            {
            a= a-b;
            }
            else
            {
                b = b - a;
            }
        }
        Console.WriteLine("GCD is :{0}",a);

    }
}

