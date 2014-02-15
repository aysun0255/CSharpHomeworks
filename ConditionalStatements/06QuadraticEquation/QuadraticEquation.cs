using System;

/*
 * 6.Write a program that enters the coefficients a, b and c of a quadratic equation
 *a*x2 + b*x + c = 0
 *and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.
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