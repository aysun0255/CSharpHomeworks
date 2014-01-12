using System;

/*
 * 5.Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
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
        int kMinusN = k - n;
        ulong kMinNFactoriel = 1;



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
            for (int i = 1; i <= kMinusN; i++)
            {
                kMinNFactoriel *= (ulong)i;
            }


            ulong result = nFactoriel * kFactoriel/kMinNFactoriel;
            Console.WriteLine("N!*K!/(K-N)! = {0}", result);
        }
        else
        {
            Console.WriteLine("You entered invalid value for n and k!N must  be larger than 1 AND K must be smaller than N.");
        }


    }
}

