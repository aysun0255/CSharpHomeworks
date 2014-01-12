using System;

/*
 * 6.Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN
 */


class CalculateSum
{
    static void Main()
    {
        checked
        {
            Console.Write("Enter value for N :");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter value for X :");
            int x = int.Parse(Console.ReadLine());
            ulong s = 1;
            ulong nFactoriel = 1;

            for (int i = 1; i <= n; i++)
            {
                nFactoriel = 1;
                nFactoriel = Factoriel(i, nFactoriel);
                s += nFactoriel / (ulong)Math.Pow(x, i);

            }
            Console.WriteLine("Sum is :{0}", s);
        }

    }

    private static ulong Factoriel(int n, ulong nFactoriel)
    {
        for (int i = 1; i <= n; i++)
        {
            nFactoriel *= (ulong)i;
        }
        return nFactoriel;
    }
}

