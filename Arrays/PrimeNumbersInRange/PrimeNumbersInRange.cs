using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 15.Write a program that finds all prime numbers in the range [1...10 000 000].
 * Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
 */

class PrimeNumbersInRange
{
    static void Main()
    {
        bool[] array = new bool[10000001];


        for (int i = 0; i < array.Length; i++)
        {
            array[i] = true;
        }

        for (int i = 2; i < array.Length; i++)
        {
            if (array[i])
            {
                int j = i + i;
                while (j <= array.Length - 1)
                {
                    array[j] = false;
                    j = j + i;
                }
            }

        }

        for (int i = 2; i < array.Length; i++)
        {
            if (array[i] == true)
            {
                Console.WriteLine(i);
            }
        }
    }
}

