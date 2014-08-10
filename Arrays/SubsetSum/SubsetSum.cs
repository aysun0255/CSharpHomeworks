using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 16 We are given an array of integers and a number S. 
 * Write a program to find if there exists a subset of the elements of the array that has a sum S. 
 * Example: arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6) 
 */

class SubsetSum
{
    static void Main()
    {
        int S = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int subsetsCount = (int)Math.Pow(2, n);
        List<int> subsetElements = new List<int>();

        for (int i = 1; i < subsetsCount; i++)
        {
            int sum = 0;
            int bitsOfI = i;
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
                    Console.Write("{0} ",subsetElements[m]);
                }
                Console.WriteLine(")");
                return;
            }
            subsetElements.Clear();
        }
        Console.WriteLine("No");


    }
}
