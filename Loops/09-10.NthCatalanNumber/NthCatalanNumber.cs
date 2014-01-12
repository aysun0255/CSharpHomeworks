using System;

/*
 * 10.Write a program to calculate the Nth Catalan number by given N.
 */

class NthCatalanNumber
{
    static void Main()
    {
        Console.Write("N =");
        int n = int.Parse(Console.ReadLine());

        if (n >= 0)
        {
            int nFactoriel = 1;
            int nDFactoriel = 1;
            int nSFactoriel = 1;
            int result = 0;

            for (int i = 1; i <= n; i++)
            {
                nFactoriel *= i;
            }

            for (int i = 1; i <= 2 * n; i++)
            {
                nDFactoriel *= i;
            }

            for (int i = 1; i <= n + 1; i++)
            {
                nSFactoriel *= i;
            }
            result = nDFactoriel / (nSFactoriel * nFactoriel);
            Console.WriteLine(result);

        }
        else
        {
            Console.WriteLine("You entered invalid value for n!");
        }

    }
}
