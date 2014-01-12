

using System;

/*
 * 6.Write a program that reads the coefficients a, b and c of a
 * quadratic equation ax2+bx+c=0 and solves it (prints its real roots).
 */

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter value for a :");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter value for b :");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter value for c :");
        double c = double.Parse(Console.ReadLine());

        double discriminant = (b * b) - 4 * a * c;

        if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2.0 * a);
            Console.WriteLine("x1 is :{0} \r\nx2 is {1}", x1, x2);
        }
        else if (discriminant == 0)
        {
            Console.WriteLine("Each x is a solution");
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("No real roots");
        }

    }
}

