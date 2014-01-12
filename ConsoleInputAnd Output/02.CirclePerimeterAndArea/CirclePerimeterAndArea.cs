using System;

/*
 * 2.Write a program that reads the radius r of a circle and prints its perimeter and area.
 */

class CirclePerimeterAndArea
{
    static void Main()
    {

        Console.Write("Enter radius of the circle:");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;
        Console.WriteLine("Perimeter is : {0} Area is :{1}",perimeter,area);


    }
}

