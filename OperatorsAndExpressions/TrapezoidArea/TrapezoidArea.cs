using System;

/*
 * 8.Write an expression that calculates trapezoid's area by given sides a and b and height h.
 */

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Enter value for a :");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter value for b :");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter value for h :");
        double h = double.Parse(Console.ReadLine());

        double trapezoidArea = 0.5 * (a + b) * h;
        Console.WriteLine("Trapezoid area is :" + trapezoidArea);
    }
}

