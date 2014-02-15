using System;

/*
 * 5.Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
 */

class ThirdBit
{
    static void Main()
    {
        int n = 73;
        int p = 3;
        int mask = 1 << p;
        int tested = mask & n;
        tested = tested >> p;
        Console.WriteLine(tested);
    }
}

