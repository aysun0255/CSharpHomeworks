using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 21.Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. 
 */

class CombinationsKDistinct
{
    static int numberOfLoops;
    static int numberOfIterations;
    static int[] loops;

    static void Main()
    {
        Console.Write("K = ");
        numberOfLoops = int.Parse(Console.ReadLine());

        Console.Write("N = ");
        numberOfIterations = int.Parse(Console.ReadLine());

        loops = new int[numberOfLoops];

        NestedLoops(0);
    }

    static void NestedLoops(int currentLoop)
    {
        if (currentLoop == numberOfLoops)
        {
            PrintLoops();
            return;
        }

        for (int counter = 1; counter <= numberOfIterations; counter++)
        {
            if (currentLoop > 0)
            {
                if (loops[currentLoop - 1] < counter)
                {
                    loops[currentLoop] = counter;
                    NestedLoops(currentLoop + 1);
                }

            }
            else if (currentLoop == 0)
            {
                loops[currentLoop] = counter;
                NestedLoops(currentLoop + 1);
            }


        }
    }

    public static void PrintLoops()
    {
        for (int i = 0; i < numberOfLoops; i++)
        {
            Console.Write("{0} ", loops[i]);
        }
        Console.WriteLine();

    }
}

