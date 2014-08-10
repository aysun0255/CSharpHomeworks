using System;
using System.Collections.Generic;

/*
 * 5.Write a program that finds the maximal increasing sequence in an array.
 * Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
 */

class MaximalIncreasingSequence
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

        List<int> elements = new List<int>();
        List<int> secondElementsList = new List<int>();
        bool sequenceEnded = false;

        for (int i = 0; i < arrayLength - 1; i++)
        {
            if (array[i] < array[i + 1] && sequenceEnded == false)
            {
                if (elements.Count == 0)
                {
                    elements.Add(array[i]);
                }
                elements.Add(array[i + 1]);
            }
            else if (array[i] < array[i + 1] && sequenceEnded == true)
            {
                if (secondElementsList.Count == 0)
                {
                    secondElementsList.Add(array[i]);
                }
                secondElementsList.Add(array[i + 1]);
                if (secondElementsList.Count > elements.Count)
                {
                    elements.Clear();
                    elements = new List<int>(secondElementsList);
                    secondElementsList.Clear();
                    sequenceEnded = false;

                }

            }
            else
            {
                sequenceEnded = true;
            }

        }


        Console.WriteLine("Maximal increasing sequence is:");
        foreach (var element in elements)
        {
            Console.Write(element + ",");
        }

    }
}
