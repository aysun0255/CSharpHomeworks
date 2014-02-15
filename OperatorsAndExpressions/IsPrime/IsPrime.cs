using System;
/*
 * 7.Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
 */

class IsPrime
{
    static void Main()
    {
        Console.Write("Enter number to check (1 < n < 100) :");
        int n = int.Parse(Console.ReadLine());
        bool isPrime = (n % 1 == 0) && (n % n == 0) && (n == 2 ? n % 2 == 0 : n % 2 != 0) && (n == 3 ? n % 3 == 0 : n % 3 != 0) && (n == 5 ? n % 5 == 0 : n % 5 != 0);
        Console.WriteLine("Is the given number prime : {0}", isPrime);

    }
}
