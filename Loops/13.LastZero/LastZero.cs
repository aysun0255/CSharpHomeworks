using System;
using System.Numerics;

/*
 * 13.Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
 *	N = 10  N! = 3628800  2
 *  N = 20  N! = 2432902008176640000  4
 *	Does your program work for N = 50 000?
 *	Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!
 */


class LastZero
{
    static void Main()
    {
        Console.Write("Enter value for n :");
        int n = int.Parse(Console.ReadLine());
        BigInteger nFactoriel = 1;
        int endZero = 0;
        int divider = 5;

        for (int i = 1; i <= n; i++)
        {
            nFactoriel *= i;
            endZero += n / divider;
            divider *= 5;
        }

        Console.WriteLine(nFactoriel);
        Console.WriteLine("Zeroes at the end :{0}", endZero);
    }
}
