using System;

/*
 * 20.Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
 */

class GenerateVariations
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
            loops[currentLoop] = counter;
            NestedLoops(currentLoop + 1);
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
