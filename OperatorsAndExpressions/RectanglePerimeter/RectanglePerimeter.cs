using System;

class RectanglePerimeter
{
    static void Main()
    {
        Console.Title = "Rectangle Perimeter And Area Calculator";

        Console.Write("Enter value for a :");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter value for b :");
        double b = double.Parse(Console.ReadLine());

        double perimeter = 2 * (a + b);
        double area = a * b;
        Console.WriteLine(" Perimeter is : {0} \n Area is :{1}", perimeter, area);
    }
}

