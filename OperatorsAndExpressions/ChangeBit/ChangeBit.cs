using System;

/*
 * 12.We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
	Example: n = 5 (00000101), p=3, v=1  13 (00001101)
	n = 5 (00000101), p=2, v=0  1 (00000001)
*/

class ChangeBit
{
    static void Main()
    {
        int n = 35; //00100011
        int p = 5;
        int v = 0; //0
        int mask = 1 << p;  // create mask to change bit in positin p
        mask = (v == 0) ? ~mask : mask; // changes value of mask according to value of v
        n = (v == 0) ? n & mask : n | mask;
        Console.WriteLine(n);
    }
}

