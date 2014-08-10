using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *10.Write a program that finds in given array of integers a sequence of given sum S (if present).
 *Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}	
 */

class SequenceSum
{
    static void Main(string[] args)
    {
        Console.Write("Enter searched sum:");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Enter array elements(seperated with ,):");
        string inputArrayOne = Console.ReadLine();
        char[] delimiter = new char[] { ',', ' ' };
        string[] inputOne = inputArrayOne.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

        int[] arr = new int[inputOne.Length];
        for (int i = 0; i < inputOne.Length; i++)
        {
            arr[i] = int.Parse(inputOne[i]);
        }

        bool sumFound = false;
        int currentSum = 0;

        List<int> sumSequence = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            currentSum += arr[i];
            sumSequence.Add(arr[i]);

            if (currentSum < s)
            {
                continue;
            }
            else if (currentSum > s)
            {
                currentSum = 0;
                sumSequence.Clear();
                i--;
            }
            else if (currentSum == s)
            {
                sumFound = true;
                break;
            }
        }

        if (sumFound)
        {
            Console.Write("Searched sum:{0} -> ", s);
            Console.Write("{");
            for (int i = 0; i < sumSequence.Count; i++)
            {
                Console.Write("{0} ", sumSequence[i]);
            }
            Console.WriteLine("}");
        }
        else
        {
            Console.WriteLine("Searched sum not present!");
        }
    }
}

