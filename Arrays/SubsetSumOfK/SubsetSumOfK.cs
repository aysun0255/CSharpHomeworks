using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 17. Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
 * Find in the array a subset of K elements that have sum S or indicate about its absence.
 */

class SubsetSumOfK
{
    static void Main()
    {
        Console.Write("s:");
        int S = int.Parse(Console.ReadLine());
        Console.Write("k:");
        int k = int.Parse(Console.ReadLine());
        Console.Write("n:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        ulong subsetsCount = Factoriel(n)/(Factoriel(k)*Factoriel(n-k));
        List<int> subsetElements = new List<int>();

        for (ulong i = 1; i < subsetsCount; i++)
        {
            int sum = 0;
            ulong bitsOfI = i;
            for (int j = 0; j < n; j++)
            {
                if (bitsOfI % 2 == 1)
                {
                    sum += array[j];
                    subsetElements.Add(array[j]);
                }
                bitsOfI = bitsOfI >> 1;
            }
            if (sum == S)
            {
                Console.Write("Yes (");
                for (int m = 0; m < subsetElements.Count; m++)
                {
                    Console.Write("{0} ", subsetElements[m]);
                }
                Console.WriteLine(")");
                return;
            }
            subsetElements.Clear();
        }
        Console.WriteLine("No");

    }

    private static ulong Factoriel(int n)
    {
        ulong factoriel = 1;

        for (int i = 1; i <= n; i++)
        {
            factoriel *= (ulong)i;
        }

        return factoriel;
    }
}

