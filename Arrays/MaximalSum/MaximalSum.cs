using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 6.Write a program that reads two integer numbers N and K and an array of N elements from the console.
 * Find in the array those K elements that have maximal sum.
 */

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter value for N:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value for K:");
        int k = 5;
        int maxSum = 0;
        int maxSumElementsStartPoint = 0;
        Console.WriteLine("Enter elements of array");
        int[] array = { 2, 3, 5, 9, 6, 8, 5, 4, 6, 3 };

        for (int i = 0; i < (array.Length - k); i++)
        {
            int tempSum = 0;
            for (int l = 0, j = i +l; l < k; l++)
            {
                tempSum += array[j];
            }

            if (tempSum > maxSum)
            {
                maxSum = tempSum;
                maxSumElementsStartPoint = i;
            }
        }

        Console.WriteLine("Elements that have maximal sum are:");
        for (int i = maxSumElementsStartPoint; i < (array.Length - k); i++)
        {
            Console.Write("{0} ",array[i]);
        }
        Console.WriteLine("Maximal sum is:{0}",maxSum);

    }
}

