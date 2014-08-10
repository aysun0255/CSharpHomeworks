using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 4.Write a program that finds the maximal sequence of equal elements in an array.
 * Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
 */

class MaximalSequence
{
    static void Main()
    {
        Console.Write("Array length:");
        int arrayLength = int.Parse(Console.ReadLine());

        int[] array = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int currentCount = 1;
        int maxCount = 0;
        int foundValue = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i-1])
            {
                currentCount++;
            }
            else
            {
                currentCount = 1;
            }

            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                foundValue = array[i];
            }  
        }

        Console.Write("The maximal sequence of equal elements is:");
        for (int i = 0; i < maxCount; i++)
        {
            Console.Write("{0},",foundValue);
        }


    }
}

