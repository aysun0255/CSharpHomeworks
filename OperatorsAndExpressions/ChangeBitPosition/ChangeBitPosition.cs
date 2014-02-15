using System;
/*
 * 13.Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
 */


class ChangeBitPosition
{
    static void Main()
    {
        int n = 170; //000000000000000000000010101010
        Console.WriteLine(n + "-" + Convert.ToString(n, 2).PadLeft(23, '0'));

        int p1 = 3;
        int p2 = 4;
        int p3 = 5;
        int p4 = 24;
        int p5 = 25;
        int p6 = 26;
        int v1, v2, v3, v4, v5, v6;
        v1 = ((1 << p1) & n) != 0 ? 1 : 0;
        v2 = ((1 << p2) & n) != 0 ? 1 : 0;
        v3 = ((1 << p3) & n) != 0 ? 1 : 0;
        v4 = ((1 << p4) & n) != 0 ? 1 : 0;
        v5 = ((1 << p5) & n) != 0 ? 1 : 0;
        v6 = ((1 << p6) & n) != 0 ? 1 : 0;
        n = (v1 == 0) ? (~(1 << p4) & n) : ((1 << p4) | n);
        n = (v2 == 0) ? (~(1 << p5) & n) : ((1 << p5) | n);
        n = (v3 == 0) ? (~(1 << p6) & n) : ((1 << p6) | n);
        n = (v4 == 0) ? (~(1 << p1) & n) : ((1 << p1) | n);
        n = (v5 == 0) ? (~(1 << p2) & n) : ((1 << p2) | n);
        n = (v6 == 0) ? (~(1 << p3) & n) : ((1 << p3) | n);

        Console.WriteLine(n + "-" + Convert.ToString(n, 2));
    }
}
