using System;

/*
 *13. Create a program that assigns null values to an integer and to double variables.
 *Try to print them on the console, try to add some values or the null literal to them and see the result.
 */

class NullValues
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;
        Console.WriteLine(nullInt);
        Console.WriteLine(nullDouble);

        nullInt = 25;
        nullDouble = 25.36;
        Console.WriteLine(nullInt);
        Console.WriteLine(nullDouble);

        nullInt = null;
        nullDouble = null;
        Console.WriteLine(nullInt);
        Console.WriteLine(nullDouble);

    }
}

