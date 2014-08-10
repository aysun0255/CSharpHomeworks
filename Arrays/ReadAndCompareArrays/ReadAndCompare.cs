using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 *2. Write a program that reads two arrays from the console and compares them element by element.
 */


class ReadAndCompare
{
    static void Main()
    {
        bool areEqual = true;
        Console.Write("Enter first array length:");
        int n1 = int.Parse(Console.ReadLine());
        int[] firstArray = new int[n1];
        Console.WriteLine("Enter array elements:");

        for (int i = 0; i < n1; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter second array length:");
        int n2 = int.Parse(Console.ReadLine());
        int[] secondArray = new int[n2];
        Console.WriteLine("Enter array elements:");

        for (int i = 0; i < n2; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }


        if (n1 == n2)
        {

            for (int i = 0; i < n1; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                   break;
                }
            }
        }
        else
        {
            areEqual = false;
        }

        if (areEqual)
        {
            Console.WriteLine("Arrays are equal");
        }
        else
        {
            Console.WriteLine("Arrays are not equal");
        }

    }
}

