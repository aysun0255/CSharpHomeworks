using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 3.Write a program that compares two char arrays lexicographically (letter by letter).
 */

class CompareCharArrays
{
    static void Main()
    {
        bool areEqual = true;
        Console.Write("Enter first array length:");
        int n1 = int.Parse(Console.ReadLine());
        char[] firstArray = new char[n1];
        Console.WriteLine("Enter array elements:");

        for (int i = 0; i < n1; i++)
        {
            firstArray[i] = char.Parse(Console.ReadLine());
        }

        Console.Write("Enter second array length:");
        int n2 = int.Parse(Console.ReadLine());
        char[] secondArray = new char[n2];
        Console.WriteLine("Enter array elements:");

        for (int i = 0; i < n2; i++)
        {
            secondArray[i] = char.Parse(Console.ReadLine());
        }


        if (n1 == n2)
        {

            for (int i = 0; i < n1; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                    string beforeOrAfter = (int)firstArray[i] < (int)secondArray[i] ? "before" : "after" ;
                    Console.WriteLine("First array is lexicographically {0} from the second array.", beforeOrAfter);
                    break;
                }
            }
        }
        else
        {
            //check which array is lexicographically before
            string beforeOrAfter = n1 < n2 ? "before" : "after";
            Console.WriteLine("First array is lexicographically {0} from the second array.",beforeOrAfter);
        }

        if (areEqual)
        {
            areEqual = false;
            Console.WriteLine("Arrays are lexicographically equal");
       }


    }
}

