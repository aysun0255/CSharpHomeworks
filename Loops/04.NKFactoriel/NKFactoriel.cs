using System;

/*
 * 4.Write a program that calculates N!/K! for given N and K (1<K<N).
 */

class NKFactoriel
{
    static void Main()
    {
        Console.Write("Enter value for N :");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value for K :");
        int k = int.Parse(Console.ReadLine());
        ulong nFactoriel = 1;
        ulong kFactoriel = 1;

        if (k > 1 && k < n)
        {
            for (int i = 1; i <= n; i++)
            {
                nFactoriel *= (ulong)i;
            }

            for (int i = 1; i <= k; i++)
            {
                kFactoriel *= (ulong)i;
            }

            ulong result = nFactoriel / kFactoriel;
            Console.WriteLine("N!/K! = {0}", result);
        }
        else
        {
            Console.WriteLine("You entered invalid value for n and k!N must  be larger than 1 AND K must be smaller than N.");
        }


    }
}

