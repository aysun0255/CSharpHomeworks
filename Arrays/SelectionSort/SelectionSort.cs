using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 7.Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
 * Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest,
 * move it at the second position, etc.
 */

class SelectionSort
{
    static void Main()
    {
        Console.Title = "Array Sort With Selection Sort Algorithm";

        Console.Write("Array length:");
        int n = int.Parse(Console.ReadLine());
        int[] intArray = new int[n];

        //Read array elements
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            intArray[i] = int.Parse(Console.ReadLine());
        }
        
        //Sort the entered array with selection sort algorithm
        for (int i = 0; i < intArray.Length; i++)
        {
            int smallestNumber = intArray[i];
            int smallestNumberPosition = i;
            for (int k = i; k <intArray.Length; k++)
            {
                if (smallestNumber > intArray[k])
                {
                    smallestNumber = intArray[k];
                    smallestNumberPosition = k;
                }
                
            }

            intArray[smallestNumberPosition] = intArray[i];
            intArray[i] = smallestNumber; 
        }

        //Print sorted array to console
        Console.Write("Sorted array: {");
        for (int i = 0; i < intArray.Length; i++)
        {
            if (i < intArray.Length-1)
            {
                Console.Write("{0},", intArray[i]);
            }
            else
            {
                Console.Write("{0}", intArray[i]);
            }
             
        }
        Console.WriteLine("}");

    }
}
