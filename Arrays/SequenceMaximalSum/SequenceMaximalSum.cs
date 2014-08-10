using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 8.Write a program that finds the sequence of maximal sum in given array. Example:
 * {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
 * Can you do it with only one loop (with single scan through the elements of the array)?
 */

class SequenceMaximalSum
{
    static void Main(string[] args)
    {
        string inputArrayOne = Console.ReadLine();
        char[] delimiter = new char[] { ',', ' ' };
        string[] inputOne = inputArrayOne.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

        int[] arr = new int[inputOne.Length];
        for (int i = 0; i < inputOne.Length; i++)
        {
            arr[i] = int.Parse(inputOne[i]);
        }

        int maxSum = 0;
        int currentSum = 0;

        List<int> maxSumSequence = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            currentSum += arr[i];
            maxSumSequence.Add(arr[i]);

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
            else if (currentSum < 0)
            {
                currentSum = 0;
                maxSumSequence.Clear();
            }
        }

        Console.Write("Max sum:{0} -> ",maxSum);
        Console.Write("{");
        for (int i = 0; i < maxSumSequence.Count; i++)
        {
            Console.Write("{0} ",maxSumSequence[i]);
        }
        Console.WriteLine("}");
        
    }
}

