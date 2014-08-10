using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *09.Write a program that finds the most frequent number in an array. Example:
 *{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
 */

class MostFrequentNumber
{
    static void Main()
    {
        Console.Write("How many numbers you want to add to array:");
        int n = int.Parse(Console.ReadLine());
        int[] intArray = new int[n];
        Console.WriteLine("Enter array elements:");

        for (int i = 0; i < n; i++)
        {
            intArray[i] = int.Parse(Console.ReadLine());
        }

        int maxCount = 0;
        int? mostFrequent = null;
        for (int i = 0; i < intArray.Length; i++)
        {
            int foundElements = Array.FindAll(intArray, element => element == intArray[i]).Length;
            if (foundElements > maxCount)
            {
                mostFrequent = intArray[i];
                maxCount = foundElements;

            }

        }

        Console.WriteLine("In given array most frequent number is:{0}({1} times)", mostFrequent, maxCount);
    }
}

