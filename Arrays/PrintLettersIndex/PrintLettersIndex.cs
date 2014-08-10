using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 12.Write a program that creates an array containing all letters from the alphabet (A-Z).
 * Read a word from the console and print the index of each of its letters in the array.
 */

class PrintLettersIndex
{
    static void Main()
    {
        char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        Console.Write("Enter word:");
        string word = Console.ReadLine();
        word = word.ToUpper();
        for (int i = 0; i < word.Length; i++)
        {
            for (int k = 0; k < letters.Length; k++)
            {
                if (word[i]==letters[k])
                {
                    Console.WriteLine("{0} -> index:{1}",word[i],k);
                }
            }
        }
    }
}

