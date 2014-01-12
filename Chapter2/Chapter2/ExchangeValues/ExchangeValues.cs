using System;

/*
 * 11.Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.
 */

class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("a={0}",a);
        Console.WriteLine("b={0}",b);
    }
}

