using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 11.Write a program that finds the index of given element
 * in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).
 */

class FindIndex
{
    static void Main()
    {
        Console.Write("Enter element to find its index:");
        int searchedElement = int.Parse(Console.ReadLine());

        Console.Write("Enter elements of sorted array(seperated with ,):");
        string inputArrayOne = Console.ReadLine();
        char[] delimiter = new char[] { ',', ' ' };
        string[] inputOne = inputArrayOne.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);



        int[] arr = new int[inputOne.Length];
        for (int i = 0; i < inputOne.Length; i++)
        {
            arr[i] = int.Parse(inputOne[i]);
        }

        if (!IsSorted(arr))
        {
            Main();
        }

        if (BinarySearch(arr, searchedElement) != -1)
        {
            Console.WriteLine("The element with value {0} has index {1}", searchedElement, BinarySearch(arr, searchedElement));
        }
        else
        {
            Console.WriteLine("The element with value {0} not found in the given array", searchedElement);
        }
    }

    //Method to check if entered array is sorted
    public static bool IsSorted(int[] arr)
    {
        int l = arr.Length;
        for (int i = 1; i < l / 2 + 1; i++)
        {
            if (arr[i - 1] > arr[i] || arr[l - i] < arr[l - i - 1])
            {
                return false;
            }
        }
        return true;
    }

    //Method for binary search
    public static int BinarySearch(int[] arr, int value)
    {
        int middle = arr.Length / 2;
        for (int i = middle; 0 <= i && i < arr.Length; )
        {
            if (value == arr[i])
            {
                return i;
            }
            else if (value < arr[i])
            {
                i--;
            }
            else if (value > arr[i])
            {
                i++;
            }

        }
        return -1;
    }
}

